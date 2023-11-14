using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MoreLinq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Media;
using System.IO;

namespace Mtg
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            // this.Icon = Properties.Resources.
            InitializeComponent();
            //start with darkmode
            //this.BackColor = DarkMode.FormBackColor;
            //this.ForeColor = DarkMode.ForeColor;

            //foreach (Control control in this.Controls)
            //{
            //    control.BackColor = DarkMode.BackColor;
            //    control.ForeColor = DarkMode.ForeColor;

            //    if (control is Button)
            //    {
            //        control.BackColor = DarkMode.ButtonBackColor;
            //        control.ForeColor = DarkMode.ButtonForeColor;
            //    }

            //}
            //foreach (Control control in this.Controls)
            //{
            //    ApplyDarkMode(control);
            //}
            //CBSelezioneMultipla.BackColor = Color.DarkGreen;
            //CbColori.BackColor = Color.DarkRed;
            //lblDeck.BackColor = Color.FromArgb(0, 192, 192);
        }
        //GLOBALI
        public static string landissime = "";
        string stringa = "";
        ListBox[] tags = new ListBox[10];
        bool Lightmode = false;
        int posizioneX = 6;
        int posizioneY = 21;
        int n = 0;
        int indice = 0;
        bool becomeBig = false;
        int StartSide = 100;
        private static readonly Regex sWhitespace = new Regex(@"\s+");
        List<ListView> Liste = new List<ListView>();
        List<Label> ListeLabel = new List<Label>();
        List<Label> ListeLabelPerc = new List<Label>();
        List<TextBox> ListeTxt = new List<TextBox>();
        List<Button> ListeBtn = new List<Button>();
        List<Card> ListeCardPrecedente = new List<Card>();
        List<Card> ListeCard = new List<Card>();
        List<ToolTip> toolTips = new List<ToolTip>();
        List<string> cardNamesPrecedente = new List<string>();
        List<string> cardNames = new List<string>();
        ListView ListaAttuale;
        ListView Listaprecedente = new ListView();
        bool isDrag = false;
        int lastY = 0;
        //
        private void ResetPanel()
        {
            Liste.ForEach(control => control.Dispose());
            ListeBtn.ForEach(control => control.Dispose());
            ListeTxt.ForEach(control => control.Dispose());
            ListeLabel.ForEach(control => control.Dispose());
            ListeLabelPerc.ForEach(control => control.Dispose());
            Liste.Clear();
            ListeBtn.Clear();
            ListeTxt.Clear();
            ListeLabel.Clear();
            ListeLabelPerc.Clear();
            indice = 0;
            posizioneX = 6;
            posizioneY = 21;
            n = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lvDeck.ItemDrag += listView1_ItemDrag;
            panel1.AutoScroll = true;
            //evita di mettere il keypress sulle textbox
            var controls = this.Controls.OfType<Control>().Where(c => !(c is TextBox));
            //aggiunge keypress
            controls.ToList().ForEach(c => c.KeyPress += lvDeck_KeyPress);
            lvDeck.Columns[0].Width = -2;
            TxtInfo.BringToFront();
            TxtInfo.MouseMove += textBox1_MouseMove;
            TxtInfo.MouseDown += textBox1_MouseDown;
            TxtInfo.MouseUp += textBox1_MouseUp;
            lvDeck.Items.Add("Click destro: elimina gli elementi selezionati");
            lvDeck.Items.Add("Click sinistro + trascina: esporta carte con effetti comuni nei tag adiacenti");
            lvDeck.Items.Add("Invio: aggiungi carte selezionate al tag selezionato");
            lvDeck.Items.Add("Cancel: rimuovi carte selezionate al tag selezionato");
            lvDeck.Items.Add("+: vai al tag successivo");
            lvDeck.Items.Add("-: vai al tag precedente");
        }
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Just add 5px padding
            if (e.Y >= (TxtInfo.ClientRectangle.Bottom - 300) &&
                e.Y <= (TxtInfo.ClientRectangle.Bottom + 300))
            {
                isDrag = true;
                lastY = e.Y;
            }
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                TxtInfo.Height += (e.Y - lastY);
                lastY = e.Y;
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                isDrag = false;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (becomeBig)
            {
                ResizeBig();
            }
        }
        private void ResizeBig()
        {
            Screen screen = Screen.FromControl(this);
            panel1.Width = screen.WorkingArea.Width - 560;
            panel1.Height = screen.WorkingArea.Height / 100 * 95;
            groupBox1.Height = screen.WorkingArea.Height / 100 * 74;
            lvDeck.Height = groupBox1.Height / 100 * 78;
            FlpOpzioniDeck.Location = new Point(lvDeck.Location.X, lvDeck.Location.Y + lvDeck.Height);
        }
        private void Eliminami_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Controls.Remove((sender as Label));
            }
        }
        private void Colora(int ris, Label sender)
        {
            if (ris <= 40)
            {
                sender.BackColor = Color.DarkRed;
            }
            else
            {
                if (40 < ris && ris <= 70)
                {
                    sender.BackColor = Color.Yellow;
                    sender.ForeColor = Color.Black;
                }
                else
                {
                    sender.BackColor = Color.Green;
                    sender.ForeColor = Color.White;
                }
            }
        }
        private void Btn_calculate_Click(object sender, EventArgs e)
        {

            try
            {
                int N = int.Parse(txtDeck.Text); //population, N
                int mano = int.Parse(txtHand.Text); //Sample, n
                int k = int.Parse(txtci.Text); //success in sample, k
                int x = int.Parse(txtsucc.Text); //x   
                if (k > N || mano > N || x > N)
                {
                    Random();
                    return;
                }
                double risutato = 0;
                int n = mano;
                //upper cumulative 
                //esattamente una carta + esattamente 2 carte + esattamente 3...fino al numero di successi presenti nel mazzo (x)
                for (int i = 0; i < mano; i++)
                {
                    BigInteger numeratore = Fatt(n) * Fatt(k) * Fatt(N - n) * Fatt(N - k);
                    BigInteger denominatore = Fatt(N) * Fatt(x) * Fatt(k - x) * Fatt(n - x) * Fatt(N - k - n + x);

                    risutato += (double)numeratore / (double)denominatore;
                    //esattamente il numero di carte che vogliamo trovare, successi precisati
                    if (i == 0)
                    {
                        //to decimal
                        int result = ToPercent(risutato);
                        //display
                        lblprec.Text = result.ToString();
                        //color 
                        if (result <= 40)
                        {
                            lblprec.BackColor = Color.Red;
                        }
                        else
                        {
                            if (40 < result && result <= 70)
                            {
                                lblprec.BackColor = Color.Yellow;
                            }
                            else
                            {
                                lblprec.BackColor = Color.Green;
                            }
                        }
                    }
                    x += 1;
                }
                //to decimal
                int resp = ToPercent(risutato);
                //display
                if (cbDrag.Checked)
                {
                    Label lbl = new Label();
                    lbl.Draggable(true);
                    lbl.Location = new Point(692, 23);
                    lbl.Size = new System.Drawing.Size(30, 30);
                    lbl.BackColor = System.Drawing.Color.SlateGray;
                    lbl.AutoSize = false;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Text = resp.ToString() + " %";
                    lbl.MouseClick += Eliminami_MouseClick;
                    lbl.Cursor = Cursors.NoMove2D;
                    lbl.MouseEnter += cbDrag_MouseEnter;
                    this.Controls.Add(lbl);
                    lbl.BringToFront();

                    Colora(resp, lbl);
                }
                lbldisplay.Text = resp.ToString();
                //color 
                Colora(resp, lbldisplay);
                //

                //fun info
                TxtInfo.Text = "Mano indica il numero di carte nella mano iniziale ma può essere usata per indicare un Turno specifico in game, eg Turno_1 = 7 carte, Turno_2= 8...";

            }
            catch (Exception)
            {
                Random();
                MessageBox.Show("inserire parametri");
            }
        }
        private string CalcolaLbl(int N, int mano, int k, int x)
        {
            try
            {
                double risutato = 0;
                int n = mano;
                //upper cumulative 
                //esattamente una carta + esattamente 2 carte + esattamente 3...fino al numero di successi presenti nel mazzo (x)
                for (int i = 0; i < mano; i++)
                {
                    BigInteger numeratore = Fatt(n) * Fatt(k) * Fatt(N - n) * Fatt(N - k);
                    BigInteger denominatore = Fatt(N) * Fatt(x) * Fatt(k - x) * Fatt(n - x) * Fatt(N - k - n + x);
                    risutato += (double)numeratore / (double)denominatore;
                    x += 1;
                }
                //to decimal
                int resp = ToPercent(risutato);
                //display
                return resp.ToString();

            }
            catch (Exception)
            {
                Random();
                MessageBox.Show("calcolo impossibile");
                return "0";
            }
        }
        /// <summary>
        ///  Esegue il fattoriale di un numero dato restituendo il calcolo
        /// </summary>
        /// <param name="numero">numero a cui fare il fattoriale</param>
        /// <returns></returns>
        public BigInteger Fatt(BigInteger numero)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= numero; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        /// <summary>
        /// Restituisce il numero da decimale a intero, non arrotonda, prende solo le due cifre più significative
        /// </summary>
        /// <param name="risutato"></param>
        /// <returns></returns>
        public int ToPercent(double risutato)
        {
            risutato = risutato * 100;
            int resp = (int)risutato;
            return resp;
        }
        private void Listview_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                Point current = panel1.AutoScrollPosition;
                Point scrolled = new Point(current.X, -current.Y + 200);
                panel1.AutoScrollPosition = scrolled;
            }
            else
            {
                Point current = panel1.AutoScrollPosition;
                Point scrolled = new Point(current.X, -current.Y - 200);
                panel1.AutoScrollPosition = scrolled;
            }


        }
        private void CreateTag()
        {
            //listview
            ListView listView = new ListView();
            Point location1 = new Point(posizioneX, posizioneY + 28);
            //serve questo passaggio in più perchè se scrolli cambia il punto di origine
            location1.Offset(panel1.AutoScrollPosition);
            listView.Location = location1;
            listView.Name = indice.ToString();
            listView.TabStop = false;
            listView.Size = new System.Drawing.Size(panel1.Size.Width / 4 - 15, 300);
            listView.View = View.List;
            listView.BackColor = DarkMode.FormBackColor;
            listView.ForeColor = System.Drawing.Color.Black;
            listView.DragEnter += new DragEventHandler(lv2_DragEnter);
            listView.DragDrop += new DragEventHandler(lv2_DragDrop);
            listView.MouseDown += lv_MouseDown;
            //listView.Scrollable = false;
            listView.KeyPress += lvDeck_KeyPress;
            listView.MouseWheel += Listview_MouseWheel;
            listView.SelectedIndexChanged += lvDeck_SelectedIndexChanged;
            listView.AllowDrop = true;
            // listView.MouseClick += lv_MouseClick; // implementato
            //textbox
            TextBox txt = new TextBox();
            Point location2 = new System.Drawing.Point(posizioneX, posizioneY);
            location2.Offset(panel1.AutoScrollPosition);
            txt.Location = location2;
            txt.MouseWheel += Listview_MouseWheel;
            txt.Name = "txt" + indice.ToString();
            txt.TabIndex = 200 + indice;
            txt.Size = new System.Drawing.Size(listView.Size.Width / 2, 220);
            //button.MouseEnter += TTelimina_MouseEnter;
            //label percentuale
            Label lblPer = new Label();
            Point location5 = new System.Drawing.Point(location2.X + listView.Size.Width / 2, posizioneY);
            location5.Offset(panel1.AutoScrollPosition);
            lblPer.Location = location5;
            lblPer.TabStop = false;
            lblPer.MouseWheel += Listview_MouseWheel;
            lblPer.Name = "lblPer" + indice.ToString();
            lblPer.Size = new System.Drawing.Size(listView.Size.Width / 2 / 3, 30);
            lblPer.Text = "0";
            lblPer.BackColor = System.Drawing.Color.SlateGray;
            lblPer.AutoSize = false;
            lblPer.TextAlign = ContentAlignment.MiddleCenter;
            //button
            Button button = new Button();
            button.Name = indice.ToString();
            button.BackColor = System.Drawing.Color.DarkRed;
            button.Text = "X";
            button.MouseWheel += Listview_MouseWheel;
            button.TabStop = false;
            Point location3 = new System.Drawing.Point(location5.X + lblPer.Size.Width, posizioneY);
            location3.Offset(panel1.AutoScrollPosition);
            button.Location = location3;
            button.Size = new System.Drawing.Size(listView.Size.Width / 2 / 3, 30);
            button.Click += Elimina_Click;
            //lblPer.MouseEnter += TTPercentuale_MouseEnter;
            //label count
            Label lbl = new Label();
            Point location4 = new System.Drawing.Point(location3.X + button.Size.Width, posizioneY);
            location4.Offset(panel1.AutoScrollPosition);
            lbl.Location = location4;
            lbl.MouseWheel += Listview_MouseWheel;
            lbl.Name = "lbl" + indice.ToString();
            lbl.Size = new System.Drawing.Size(listView.Size.Width / 2 / 3, 30);
            lbl.Text = "0";
            lbl.TabStop = false;
            lbl.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.TextChanged += label_TextChanged;
            //lbl.MouseEnter += TTPNumero_MouseEnter;
            //add all
            panel1.Controls.Add(button);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(txt);
            panel1.Controls.Add(listView);
            panel1.Controls.Add(lblPer);
            posizioneX += panel1.Size.Width / 4;
            n++;
            indice++;
            if (n == 4)
            {
                n = 0;
                posizioneY += 340;
                posizioneX = 6;
            }
            ListeTxt.Add(txt);
            ListeLabel.Add(lbl);
            Liste.Add(listView);
            ListeBtn.Add(button);
            ListeLabelPerc.Add(lblPer);
            Colora(listView);

            //int o = 0;
            foreach (var control in ListeTxt)
            {

                control.MouseEnter += (sender, args) => toolTip1.Show("nome Tag", control);
                control.MouseLeave += (sender, args) => toolTip1.Hide(control);
                //ListeBtn[o].MouseEnter += (sender, args) => toolTip1.Show("Elimina tutte le carte in questo tag", control);
                //ListeBtn[o].MouseLeave += (sender, args) => toolTip1.Hide(control);
                //ListeLabel[o].MouseEnter += (sender, args) => toolTip1.Show("Numero di carte", control);
                //ListeLabel[o].MouseLeave += (sender, args) => toolTip1.Hide(control);
                //ListeLabelPerc[o].MouseEnter += (sender, args) => toolTip1.Show("Percentuale di trovare la carta", control);
                //ListeLabelPerc[o].MouseLeave += (sender, args) => toolTip1.Hide(control);
                //Liste[o].MouseEnter += (sender, args) => toolTip1.Show("Carte Taggate", control);
                //Liste[o].MouseLeave += (sender, args) => toolTip1.Hide(control);
            }
            foreach (var control in ListeBtn)
            {

                control.MouseEnter += (sender, args) => toolTip1.Show("Elimina tutte le carte in questo tag", control);
                control.MouseLeave += (sender, args) => toolTip1.Hide(control);
            }
            foreach (var control in ListeLabel)
            {

                control.MouseEnter += (sender, args) => toolTip1.Show("Numero di carte", control);
                control.MouseLeave += (sender, args) => toolTip1.Hide(control);
            }
            foreach (var control in ListeLabelPerc)
            {

                control.MouseEnter += (sender, args) => toolTip1.Show("Percentuale di trovare la carta", control);
                control.MouseLeave += (sender, args) => toolTip1.Hide(control);
            }
            foreach (var control in Liste)
            {

                control.MouseEnter += (sender, args) => toolTip1.Show("Carte Taggate", control);
                control.MouseLeave += (sender, args) => toolTip1.Hide(control);
            }


        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            string nome = btn.Name;
            int name = int.Parse(nome);
            ListeTxt[int.Parse(nome)].Text = "";
            ListeLabel[int.Parse(nome)].Text = "0";
            //per ogni elemento dentro alla lista da eliminare
            foreach (ListViewItem item in Liste[name].Items)
            {
                bool ColoreEliminabile = true;
                //se non è contenuto dentro un'altra lista(per capire che non è lei dobbiamo prenderle tutte come stiamo facendo ora)
                foreach (ListView altraView in Liste)
                {
                    //una lista che non sia lei
                    if (altraView != (Liste[name] as ListView))
                    {
                        // per ogni item dentro un'altra lista
                        foreach (ListViewItem itemDentroViewNonlei in altraView.Items)
                        {
                            //se non c'è uno simile
                            if (itemDentroViewNonlei.Text == item.Text)
                            {
                                ColoreEliminabile = false;
                            }
                        }
                    }
                }
                //allora se non c'è uno uguale puoi eliminare il colore
                if (ColoreEliminabile)
                {
                    foreach (ListViewItem deck in lvDeck.Items)
                    {
                        if (item.Text == deck.Text)
                        {
                            if (Lightmode == true)
                            {
                                deck.BackColor = SystemColors.Control;
                            }
                            else
                            {
                                deck.BackColor = DarkMode.BackColor;
                            }
                        }
                    }
                }

            }
            ListeLabelPerc[int.Parse(nome)].Text = "0";
            Liste[int.Parse(nome)].Clear();
            AggiornaCounters();
        }

        private void CreaTag_Click(object sender, EventArgs e)
        {
            if (indice == 0)
            {
                CreateTag();
                Liste[0].Visible = false;
                ListeLabel[0].Visible = false;
                ListeTxt[0].Visible = false;
                ListeBtn[0].Visible = false;
                CreateTag();
            }
            else
            {
                CreateTag();
            }

        }
        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //aggiungi 'a capo' per separare le carte
            string mazzo = "";
            foreach (string item in textBox1.Lines)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    //bool inseribile = true;
                    string nomecarta = item;
                    //eliminiamo i primi due numeri
                    int counter = 0;
                    do
                    {
                        nomecarta = nomecarta.Substring(nomecarta.IndexOfAny("1234567890".ToCharArray()) + 1);
                        counter++;
                    } while ((char.IsDigit(nomecarta[0])) && (counter < 2));
                    //foreach (Card carta in ListeCard)
                    //{
                    //    if (ReplaceWhitespace(carta.name, "").ToLower() == ReplaceWhitespace(nomecarta, "").ToLower())
                    //    {
                    //        inseribile = false;
                    //        break;
                    //    }
                    //}
                    //if (inseribile)
                    //{   //usiamo item perchè contiene i numeri e ci servono per capire quante terre (base) ci sono per
                    //il conteggio dei colori
                    mazzo += item + "\r\n";
                    //}
                }
            }
            AggiungiADeck(mazzo, true);
        }
        private async void btnClip_Click(object sender, EventArgs e)
        {
            btnClip.BackColor = Color.Red;
            btnClip.Enabled = false;
            lvDeck.Items.Clear();
            ListeCard.Clear();
            foreach (ListView lista in Liste)
            {
                lista.Clear();
            }
            AggiornaCounters();
            cardNames.Clear();
            //se la clipboard contiene roba, stampiamo nella view tutti le righe e per ognuna costruiamo un oggetto con cui poi
            //facciamo una call unica dopo
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                AggiungiADeck(clipboardText, false);
            }
            btnClip.BackColor = DarkMode.ButtonBackColor;
            btnClip.Enabled = true; ;
        }
        public void AggiungiADeck(string Testo, bool aggiungi)
        {
            Task.Run(() =>
            {
                AutoClosingMessageBox.Show("Caricamento", "Caricamento Mazzo", 3000);
            });


            string lines = Testo.Replace("\r\n", "$");
            string[] split = lines.Split('$');
            bool end = false;
            //cicliamo dal fondo
            for (int i = split.Length - 1; i >= 0 && end == false; i--)
            {
                if (split[i] == "")
                    Array.Resize<string>(ref split, i);
                else
                {
                    end = true;
                }
            }
            for (int i = 0; i < split.Length; i++)
            {
                int index = split[i].IndexOf("(");
                if (index != -1)
                {
                    split[i] = split[i].Substring(0, index);
                }
            }
            List<string> CarteAggiunte = ImportaCarte(split);
            lblDeck.Text = ListeCard.Count.ToString();
            //semplice aggiunta di carte in più
            if (aggiungi)
            {
                lvDeck.Items.Add("/// carte aggiunte ////").ForeColor = Color.Green;
                foreach (var item in CarteAggiunte)
                {
                    lvDeck.Items.Add(item);
                }
            }
            else
            {

                //importando da clipboard
                //Suddividiamo le carte per tipo in un oggetto specifico
                MazzoTipo mazzoditipo = new MazzoTipo();
                for (int i = 0; i < ListeCard.Count; i++)
                {
                    Card carta = ListeCard[i];
                    //non c'è metodo metodico per farlo per via di carte con 2 tipi, "creatura artefatto" specie
                    //per future edizioni, più c'è la questione della gerachia dove nonostante sia due tipi solo
                    //una può esserlo e viene deciso in modo arbitrario con "creatura" che ha peso maggiore, 
                    if (i >= StartSide)
                        mazzoditipo.Listatipi[7].CarteDiTipo.Add(carta.name);
                    else
                    {
                        if (carta.type_line.ToLower().Contains("creature"))
                            mazzoditipo.Listatipi[1].CarteDiTipo.Add(carta.name);
                        else
                        {
                            if (carta.type_line.ToLower().Contains("land"))
                                mazzoditipo.Listatipi[6].CarteDiTipo.Add(carta.name);
                            else
                            {
                                if (carta.type_line.ToLower().Contains("artifact"))
                                    mazzoditipo.Listatipi[0].CarteDiTipo.Add(carta.name);
                                else
                                {
                                    if (carta.type_line.ToLower().Contains("enchantment"))
                                        mazzoditipo.Listatipi[2].CarteDiTipo.Add(carta.name);
                                    else
                                    {
                                        if (carta.type_line.ToLower().Contains("planeswalker"))
                                            mazzoditipo.Listatipi[3].CarteDiTipo.Add(carta.name);
                                        else
                                        {
                                            if (carta.type_line.ToLower().Contains("instant"))
                                                mazzoditipo.Listatipi[4].CarteDiTipo.Add(carta.name);
                                            else
                                            {
                                                if (carta.type_line.ToLower().Contains("sorcery"))
                                                    mazzoditipo.Listatipi[5].CarteDiTipo.Add(carta.name);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                //stampiamo
                foreach (CarteTipo Tipo in mazzoditipo.Listatipi)
                {
                    if (Tipo.CarteDiTipo.Count > 0)
                    {
                        //stampiamo il tipo
                        lvDeck.Items.Add("///" + Tipo.Tipo + "////").ForeColor = Color.Green;
                        string[] splitCarteTipo = Tipo.ButtaInStringa().Split('$');
                        TextBox trovata = null;
                        foreach (var item in splitCarteTipo)
                        {
                            //stampiamo la carta direttamente nel deck
                            lvDeck.Items.Add(item);

                            //se è una landa andiamo a creare il tag già fatto 
                            if (Tipo.Tipo.ToLower().Trim().Contains("land"))
                            {
                                if (trovata == null)
                                {
                                    foreach (TextBox testo in ListeTxt)
                                    {
                                        if (testo.Text.Trim().ToLower() == "land" || testo.Text.Trim().ToLower() == "landa" || testo.Text.Trim().ToLower() == "mana" || testo.Text.Trim().ToLower() == "terra" || testo.Text.Trim().ToLower() == "lande" || testo.Text.Trim().ToLower() == "terre" || testo.Text.Trim().ToLower() == "")
                                        {
                                            trovata = testo;
                                        }
                                    }
                                    //se ancora non è stata trovata una textbox e relativa listview dove poter scrivere
                                    //ne creiamo una creando un tag
                                    if (trovata == null)
                                    {
                                        object s = new object();
                                        EventArgs e = new EventArgs();
                                        CreaTag_Click(s, e);
                                        trovata = ListeTxt.Last();
                                    }
                                }
                                //troviamo la listview associata a trovata
                                int found = int.Parse(trovata.Name.Substring(3));
                                Liste[found].Items.Add(item);
                                trovata.Text = "Land";
                                //Coloriamo l'ultimo item messo nella deck list di verde
                                lvDeck.Items[lvDeck.Items.Count - 1].BackColor = Color.Green;
                            }
                        }
                        int ultimoPosto = lvDeck.Items.Count - 1;
                        foreach (var item in splitCarteTipo)
                        {
                            //se è una landa andiamo a creare il tag già fatto 
                            if (Tipo.Tipo.ToLower().Trim().Contains("side"))
                            {
                                if (trovata == null)
                                {
                                    foreach (TextBox testo in ListeTxt)
                                    {
                                        if (testo.Text.Trim().ToLower().Contains("side"))
                                        {
                                            trovata = testo;
                                        }
                                    }
                                    //se ancora non è stata trovata una textbox e relativa listview dove poter scrivere
                                    //ne creiamo una creando un tag
                                    if (trovata == null)
                                    {
                                        object s = new object();
                                        EventArgs e = new EventArgs();
                                        CreaTag_Click(s, e);
                                        trovata = ListeTxt.Last();
                                    }
                                }
                                //troviamo la listview associata a trovata
                                int found = int.Parse(trovata.Name.Substring(3));
                                Liste[found].Items.Add(item);
                                trovata.Text = "Side";
                                //Coloriamo l'ultimo item messo nella deck list di verde
                                lvDeck.Items[ultimoPosto--].BackColor = Color.Green;
                            }
                        }
                    }
                }
                AggiornaCounters();
            }
        }

        private List<string> ImportaCarte(string[] split)
        {
            List<Card> carteRisposta = new List<Card>();
            List<string> CarteAggiunte = new List<string>();
            foreach (string line in split)
            {
                StartSide = 100;
                if (!string.IsNullOrWhiteSpace(line))
                {
                    //eliminiamo tutti i numeri primi 2 numeri se ci sono
                    string nomecarta = line;
                    int counter = 0;
                    do
                    {
                        nomecarta = nomecarta.Substring(nomecarta.IndexOfAny("1234567890".ToCharArray()) + 1);
                        counter++;
                    } while ((char.IsDigit(nomecarta[0])) && (counter < 2));

                    int numeroCicli = 0;
                    //controlla se ci sono 2 numeri all'inizio della stringa
                    if (Regex.IsMatch(line, "^[0-9]{2}"))
                    {
                        numeroCicli = int.Parse(line.Substring(0, 2));
                    }
                    else
                    {//controlla se c'è un solo numero nella stringa
                        if (Regex.IsMatch(line, "^[0-9]{1}"))
                        {
                            numeroCicli = int.Parse(line.Substring(0, 1));
                        }
                        else
                        {
                            numeroCicli = 1;
                        }
                    }
                    for (int i = 0; i < numeroCicli; i++)
                    {
                        //aggiunge al deck
                        CarteAggiunte.Add(nomecarta);
                    }

                }
                else
                {
                    StartSide = Array.IndexOf(split, line);
                }
            }
            try
            {
                //riduciamo la lista in liste più piccole da massimo 70 elementi (il massimo di carte per chiamata è 75)                   
                var small = CarteAggiunte.Batch(70).ToList();
                //per ogni lista da 70 oggetti facciamo una mega chiamata
                for (int i = 0; i < small.Count; i++)
                {
                    var newList = small[i];
                    //trasformiamo la lista nell'array di json
                    JArray identifiers = new JArray();
                    foreach (string cardName in newList)
                    {
                        JObject identifier = new JObject();
                        identifier["name"] = cardName;
                        identifiers.Add(identifier);
                    }
                    JObject jsonObject = new JObject();
                    //deve esserci questo identifiers altrimenti i soli nomi non gli piacciono
                    jsonObject["identifiers"] = identifiers;
                    string jsonString = jsonObject.ToString();
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpClient client = new HttpClient();
                    var result = client.PostAsync("https://api.scryfall.com/cards/collection", content).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var contenuto = result.Content.ReadAsStringAsync().Result;
                        var cardsJson = JObject.Parse(contenuto);
                        var data = cardsJson["data"].ToList();
                        var cards = data.Select(c => JsonConvert.DeserializeObject<Card>(c.ToString()));
                        foreach (Card item in cards)
                        {
                            ListeCard.Add(item);
                            carteRisposta.Add(item);
                        }
                    }
                }
            }
            catch (Exception error)
            { }
            cardNames.Clear();
            foreach (Card carta in ListeCard)
            {
                cardNames.Add(carta.name.Trim().ToLower());
            }

            return CarteAggiunte;
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(ListBox.SelectedObjectCollection)) != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label_TextChanged(object sender, EventArgs e)
        {
            Label questa = (sender as Label);
            int indiceInterno = int.Parse(questa.Name.Substring(3));
            //int ci = (Liste[indiceInterno] as ListView).Items.Count;
            int ci = int.Parse(questa.Text);
            Label targetPercentuale = (ListeLabelPerc[indiceInterno] as Label);
            targetPercentuale.Text = CalcolaLbl(int.Parse(txtDeck.Text), int.Parse(txtHand.Text), ci, int.Parse(txtsucc.Text)) + " %";
            int percentuale = int.Parse(targetPercentuale.Text.Substring(0, 2));
            //color 
            Colora(percentuale, targetPercentuale);
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Start the drag-and-drop operation with the selected item
            lvDeck.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as ListBox).DoDragDrop((sender as ListBox).SelectedItems, DragDropEffects.Move);
        }
        private void lvDeck_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as ListView).DoDragDrop((sender as ListView).SelectedItems, DragDropEffects.Move);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetPanel();
            lvDeck.Items.Clear();
            textBox1.Clear();
            ListeCard.Clear();
            foreach (ListView lista in Liste)
            {
                lista.Clear();
            }
            AggiornaCounters();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
                panel1.Visible = false;
                becomeBig = false;
                WindowState = FormWindowState.Normal;
                Size = new Size(250, 200);
                lblTotalTags.Visible = false;
                LblTot.Visible = false;
                panel2.Visible = false;
            }
            else
            {
                ///////////////////////////////////////////////////
                groupBox1.Visible = true;
                panel1.Visible = true;
                panel2.Visible = true;
                ResizeBig();
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
                becomeBig = true;
                lblTotalTags.Visible = true;
                LblTot.Visible = true;
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (this.BackColor == DarkMode.FormBackColor)
            {
                Lightmode = true;
                // Change to light mode
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                foreach (Control control in this.Controls)
                {
                    ApplyLightMode(control);
                }
            }
            else
            {
                // Change to dark mode
                Lightmode = false;
                this.BackColor = DarkMode.FormBackColor;
                this.ForeColor = DarkMode.ForeColor;

                foreach (Control control in this.Controls)
                {
                    ApplyDarkMode(control);
                }
            }

        }

        private void ApplyDarkMode(Control control)
        {
            if (control is CheckBox || control is Chart)
            {
                return;
            }
            control.BackColor = DarkMode.BackColor;
            control.ForeColor = DarkMode.ForeColor;
            if (control is GroupBox)
            {
                foreach (Control childControl in control.Controls)
                {
                    ApplyDarkMode(childControl);
                }
            }
            if (control is Panel)
            {
                foreach (Control childControl in control.Controls)
                {
                    if (!(childControl is Label))
                    {
                        ApplyDarkMode(childControl);
                    }
                }
            }
            if (control is ListView)
            {
                foreach (ListViewItem childControl in (control as ListView).Items)
                {
                    childControl.BackColor = DarkMode.BackColor;
                    childControl.ForeColor = DarkMode.ForeColor;
                }
            }
            if (control is Button)
            {
                if (control.Text.ToLower() != "x")
                {
                    control.BackColor = DarkMode.BackColor;
                    control.ForeColor = DarkMode.ForeColor;
                }
                else
                {
                    control.BackColor = Color.DarkRed;
                }
            }
        }
        private void ApplyLightMode(Control control)
        {
            if (control is CheckBox || control is Chart)
            {
                return;
            }
            control.BackColor = SystemColors.ControlDark;
            control.ForeColor = SystemColors.ControlText;

            if (control is GroupBox)
            {
                foreach (Control childControl in control.Controls)
                {
                    ApplyLightMode(childControl);
                }
            }
            if (control is Panel)
            {
                foreach (Control childControl in control.Controls)
                {
                    if (!(childControl is Label))
                    {
                        ApplyLightMode(childControl);
                    }
                }
            }
            if (control is ListView)
            {
                foreach (ListViewItem childControl in (control as ListView).Items)
                {
                    childControl.BackColor = SystemColors.Control;
                    childControl.ForeColor = SystemColors.ControlText;
                }
            }
            if (control is Button)
            {
                if (control.Text.ToLower() != "x")
                {
                    control.BackColor = SystemColors.Control;
                    control.ForeColor = SystemColors.ControlText;
                }
                else
                {
                    control.BackColor = Color.DarkRed;
                }
            }
        }
        private void lv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((sender as ListView).SelectedItems.Count > 0)
                {
                    ListViewItem[] selectedItems = new ListViewItem[(sender as ListView).SelectedItems.Count];
                    (sender as ListView).SelectedItems.CopyTo(selectedItems, 0);
                    (sender as ListView).DoDragDrop(selectedItems, DragDropEffects.Move);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                ListeCardPrecedente = new List<Card>(ListeCard);
                cardNamesPrecedente = new List<string>(cardNames);
                //conta il numero di occorrenze di ogni item selezionato
                ListView.SelectedListViewItemCollection selectedItems = (sender as ListView).SelectedItems;
                Dictionary<string, int> count = new Dictionary<string, int>();
                foreach (ListViewItem item in selectedItems)
                {
                    //se count ha già una chiave con il testo del item selezionato aggiunge 1 al counter altrimenti lo crea
                    count[item.Text] = count.ContainsKey(item.Text) ? count[item.Text]++ : 1;
                }//sono ora tutti dentro alla dictionary
                foreach (ListViewItem item in (sender as ListView).SelectedItems)
                {
                    //se non stiamo eliminando da lvdeck
                    if ((sender as ListView).Name != "lvDeck")
                    {
                        bool ColoreEliminabile = true;
                        //se non è contenuto dentro un'altra lista(per capire che non è lei dobbiamo prenderle tutte come stiamo facendo ora)
                        foreach (ListView altraView in Liste)
                        {
                            //una lista che non sia lei
                            if (altraView != (Liste[int.Parse((sender as ListView).Name)] as ListView))
                            {
                                // per ogni item dentro un'altra lista
                                foreach (ListViewItem itemDentroViewNonlei in altraView.Items)
                                {
                                    //se non c'è uno simile
                                    if (itemDentroViewNonlei.Text == item.Text)
                                    {
                                        ColoreEliminabile = false;
                                    }
                                }
                            }
                        }
                        //allora se non c'è uno uguale puoi eliminare il colore
                        if (ColoreEliminabile)
                        {
                            //crea variabile count 
                            if (count.TryGetValue(item.Text, out int currentCount) && --currentCount >= 0)
                            {
                                count[item.Text] = currentCount;
                                var CartaInDeck = lvDeck.Items.Cast<ListViewItem>().FirstOrDefault(d => d.Text == item.Text && d.BackColor == Color.Green);
                                if (CartaInDeck != null)
                                {
                                    CartaInDeck.BackColor = DarkMode.BackColor;
                                }
                            }
                        }
                    }
                    else
                    {

                        //eliminiamo tutti i numeri primi 2 numeri se ci sono
                        string nomecartaSenzaNumeri = item.Text;
                        int counter = 0;
                        do
                        {
                            nomecartaSenzaNumeri = nomecartaSenzaNumeri.Substring(nomecartaSenzaNumeri.IndexOfAny("1234567890".ToCharArray()) + 1);
                            counter++;
                        } while ((char.IsDigit(nomecartaSenzaNumeri[0])) && (counter < 2));

                        int numeroCicli = 0;
                        //controlla se ci sono 2 numeri all'inizio della stringa
                        if (Regex.IsMatch(item.Text, "^[0-9]{2}"))
                            numeroCicli = int.Parse(item.Text.Substring(0, 2));
                        else
                        {//controlla se c'è un solo numero nella stringa
                            if (Regex.IsMatch(item.Text, "^[0-9]{1}"))
                                numeroCicli = int.Parse(item.Text.Substring(0, 1));
                            else
                                numeroCicli = 1;
                        }
                        for (int i = 0; i < numeroCicli; i++)
                        {

                            foreach (Card carta in ListeCard)
                            {
                                if (carta.name.Trim().ToLower() == nomecartaSenzaNumeri.Trim().ToLower())
                                {
                                    cardNames.Remove(nomecartaSenzaNumeri.Trim().ToLower());
                                    ListeCard.Remove(carta);
                                    break; //non puoi eliminare la carta e continuare a ciclare sulla lista
                                    //ecco perchè serve il numero di cicli ed il break
                                }
                            }
                        }
                        //elimina da ogni listview nel pannello
                        foreach (ListViewItem selected in lvDeck.SelectedItems)
                        {
                            //controlla in tutte le lv dentro pannello
                            foreach (ListView lv in panel1.Controls.OfType<ListView>())
                            {
                                //cerca se la carta selezionata è uguale ad una dentro la lv
                                var CartaInLv = lv.Items.Cast<ListViewItem>().FirstOrDefault(i => i.Text.ToLower() == selected.Text.ToLower());
                                if (CartaInLv != null)
                                {
                                    CartaInLv.Remove();
                                    break;
                                }
                            }
                        }
                    }
                    item.Remove();
                    AggiornaCounters();
                }
            }
        }

        private void lv2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void TrasferisciInLV(object sender, ListViewItem[] trasferibile)
        {
            //Elementi e numero copie presenti in deck 

            Dictionary<string, int> countListViewDeck = new Dictionary<string, int>();
            foreach (ListViewItem item in lvDeck.Items)
            {
                //se count ha già una chiave con il testo del item selezionato aggiunge 1 al counter altrimenti lo crea
                countListViewDeck[item.Text] = countListViewDeck.ContainsKey(item.Text) ? countListViewDeck[item.Text] + 1 : 1;
            }
            //Elementi e numero copie presenti nella listview dove muoviamo
            ListView destListView = sender as ListView;
            Dictionary<string, int> CopieDestinazione = new Dictionary<string, int>();
            foreach (ListViewItem item in destListView.Items)
            {
                CopieDestinazione[item.Text] = CopieDestinazione.ContainsKey(item.Text) ? CopieDestinazione[item.Text] + 1 : 1;
            }
            int cartespostateCiclando = 0;
            //per ogni item
            foreach (ListViewItem item in trasferibile)
            {
                //settiamo che non c'è niente nella lista finale
                int itemCountInListView2 = 0;
                int itemCountInListView1 = countListViewDeck[item.Text];
                //controlliamo che ci sia qualcosa nella lista di destinazione
                if (CopieDestinazione.Count > 0)
                {
                    //c'è quindi controlliamo che ci sia almeno una copia di ciò che stiamo inserendo
                    if (CopieDestinazione.Keys.Contains(item.Text))
                    {
                        //c'è quindi prendiamo il numero di copie associate al testo
                        itemCountInListView2 = CopieDestinazione[item.Text];
                    }
                }
                int difference = itemCountInListView1 - itemCountInListView2 + cartespostateCiclando;
                //controlliamo che il numero di carte uguali nel mazzo iniziale sia più grande rispetto a quelli 
                //inseriti
                if (difference > 0)
                {
                    //lo è quindi inseriamo
                    var newItem = new ListViewItem(item.Text);
                    newItem.SubItems.AddRange(item.SubItems.Cast<ListViewItem.ListViewSubItem>().ToArray());
                    newItem.ImageKey = item.ImageKey;
                    newItem.ForeColor = item.ForeColor;
                    destListView.Items.Add(newItem);
                    cartespostateCiclando++;
                }

            }
            foreach (ListViewItem item in lvDeck.SelectedItems)
            {
                item.BackColor = Color.Green;
            }
            //aggiorna OGNI label con il numero di items contenuti nella rispettiva listview
            AggiornaCounters();
        }
        private void lv2_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem[] items = e.Data.GetData(typeof(ListViewItem[])) as ListViewItem[];
            if (items == null) return;
            TrasferisciInLV(sender, items);
        }

        private void lvDeck_MouseUp(object sender, MouseEventArgs e)
        {
            lvDeck.Focus();
        }

        private void Colora(ListView listView)
        {
            Listaprecedente.BackColor = DarkMode.FormBackColor;
            ListaAttuale = (listView as ListView);
            ListaAttuale.BackColor = Color.FromArgb(103, 87, 142);
            Listaprecedente = ListaAttuale;
        }
        private async void lvDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //removal of the NUMBER (if any cards start with a number fuck it)
                string cardName = (sender as ListView).SelectedItems[0].Text;
                cardName = cardName.Substring(cardName.IndexOfAny("1234567890".ToCharArray()) + 1);
                if (char.IsDigit(cardName[0]))
                {
                    cardName = cardName.Substring(cardName.IndexOfAny("1234567890".ToCharArray()) + 1);
                }
                //prima di mostrare la carta ci assicuriamo che non sia già presente tra quelle già scaricate
                bool chiamata = true;
                string cartadamostrare = "";
                string ultimi2caratteri = cardName.Substring(cardName.Length - 2);
                if (ultimi2caratteri == "\r")
                {
                    cardName = cardName.Substring(0, cardName.Length - 1);
                }

                foreach (Card carta in ListeCard)
                {
                    string prima = carta.name.ToLower().Trim();
                    string seconda = cardName.ToLower().Trim();
                    if (prima == seconda)
                    {
                        chiamata = false;
                        if (carta.image_uris != null)
                        {

                            cartadamostrare = carta.image_uris.Large;
                        }
                        else
                        {
                            cartadamostrare = carta.card_faces[0].image_uris.Large;
                        }
                        break;
                    }
                }
                if (chiamata)
                {
                    //non lo è quindi facciamo la request e la aggiungiamo
                    HttpClient client = new HttpClient();
                    var response = await client.GetStringAsync($"https://api.scryfall.com/cards/named?exact={cardName}&lang=it");
                    //var response = await client.GetStringAsync("https://api.scryfall.com/cards/named?exact=isola&lang=it");
                    Card card = JsonConvert.DeserializeObject<Card>(response);
                    //ListeCard.Add(card);
                    if (card.image_uris !=  null)
                    {
                        pictureBox1.ImageLocation = card.image_uris.Large;
                    }
                    else
                    {
                        pictureBox1.ImageLocation = card.card_faces[0].image_uris.Large;
                    }
                }
                else
                {
                    pictureBox1.ImageLocation = cartadamostrare;
                }
            }
            catch (Exception)
            { }
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            try
            {
                //bool empty = false;
                //foreach (Control item in panel1.Controls)
                //{
                //    if (item is TextBox)
                //    {
                //        if (item != ListeTxt[0])
                //        {
                //            if (item.Text == "")
                //            {
                //                empty = true;
                //            }

                //        }
                //    }
                //}
                bool empty = panel1.Controls.OfType<TextBox>().Any(t => t != ListeTxt[0] && string.IsNullOrEmpty(t.Text));
                Dictionary<string, string> carteNumero = new Dictionary<string, string>();
                for (int i = 1; i < Liste.Count; i++)
                {
                    foreach (ListViewItem NomeCarta in Liste[i].Items)
                    {
                        //se non c'è lo mette nel dizionario altrimenti lo aggiunge al valore
                        carteNumero[NomeCarta.Text] = carteNumero.ContainsKey(NomeCarta.Text) ?
                        carteNumero[NomeCarta.Text] + "#" + ListeTxt[i].Text : "#" + ListeTxt[i].Text;
                    }
                }
                stringa = "";
                string stringaSide = "";
                foreach (var item in carteNumero)
                {
                    string value = item.Value.Trim().ToLower();
                    //se trovi la tag side mettile in una stringa a parte
                    if (item.Value.Trim().ToLower().Contains("side"))
                    {
                        stringaSide += item.Key + value.Replace("#sideboard", "").Replace("#side", "") + "\n";
                    }
                    else
                    {
                        //metti i tag globali se trovi terre
                        if (item.Value.Trim().ToLower().Contains("land"))
                        {
                            //rejex con tutte le parole possibili per indicare terra
                            string word = "#lande|#terre|#landa|#terra|#mana|#land|#!land|#!Land";
                            string replacement = "#!Land";
                            string tmp = item.Value.ToLower().Trim();
                            //rimpiazza ogni istanza di word con il tag globale di moxifield per le lande
                            tmp = Regex.Replace(tmp, word, replacement, RegexOptions.IgnoreCase);
                            //conta quante volte il tag globale è presente
                            int count = Regex.Matches(tmp, replacement).Count;
                            //rimuoviamo tutti i tag #!Land
                            tmp = tmp.Replace("#!Land", "");
                            //stampiamo per il numero di tag trovati
                            for (int i = 0; i < count; i++)
                            {
                                stringa += item.Key + tmp + "#!Land" + "\n";
                            }
                        }
                        else
                        {
                            //se non sono in side e non sono lande
                            stringa += item.Key + item.Value + "\n";
                        }
                    }
                }
                if (stringa != null && stringa != "")
                {
                    Clipboard.SetText(stringa + "\n\r" + stringaSide);
                    MessageBox.Show("Mazzo Copiato Negli Appunti");
                }
                else
                {
                    AutoClosingMessageBox.Show( "'Porta sul nulla' ha qualcosa in comune con le tue carte copiate", "Errore", 4000);
                }
                if (empty == true)
                {
                    Random();
                    MessageBox.Show("Uno dei tuoi tag non ha nome, terre base / carte ripetibili saranno salvate male");
                }
            }
            catch (Exception)
            {
                Random();
                MessageBox.Show("Copiatura andata male");
            }

        }

        //private void btnEliminaSelezionati_Click(object sender, EventArgs e)
        //{
        //    //NON DISPONIBILE, PRIMA FIXARE IL PROBLEMA CON LE CARTE DOPPIE [(PATHWAY E IN GENERALE CON // NEL NOME) SE NON VENGONO ELIMINATE 
        //    //DALL'INDICE DELLE CARTE NE FETCHATE ROMPE IL CERCARE NEI TESTI E TENERE CONTO IN MODO SICURO DELLA LISTA DI CARTE] E POI
        //    //IMPLEMENTARLO QUI
        //    //
        //    //foreach (ListViewItem item in lvDeck.SelectedItems)elegante ma lento, piuttosto che fare tutto ciò per ogni items fai il check dentro alle listview
        //    // {
        //    //elimina da ogni listview nel pannello
        //    foreach (Control controllo in panel1.Controls)
        //    {
        //        if (controllo is ListView)
        //        {
        //            foreach (ListViewItem check in (controllo as ListView).Items)
        //            {
        //                foreach (ListViewItem selected in lvDeck.SelectedItems)
        //                {
        //                    if (check.Text.ToLower() == selected.Text.ToLower())
        //                    {
        //                        check.Remove();

        //                    }
        //                }
        //            }
        //        }
        //    }
        //    //elimina dalla listview deck
        //    //item.Remove();
        //    // }
        //    //elimina successivamente dalla view deck
        //    foreach (ListViewItem item in lvDeck.SelectedItems)
        //    {
        //        item.Remove();
        //    }
        //    //aggiorna ogni counter 
        //    AggiornaCounters();
        //}
        private void AggiornaCounters()
        {

            int i = 0;
            foreach (Label l in ListeLabel)
            {
                int numeroCicli = 0;
                foreach (ListViewItem item in Liste[i].Items)
                {

                    //controlla se ci sono 2 numeri all'inizio della stringa
                    if (Regex.IsMatch(item.Text, "^[0-9]{2}"))
                    {
                        numeroCicli += int.Parse(item.Text.Substring(0, 2));
                    }
                    else
                    {//controlla se c'è un solo numero nella stringa
                        if (Regex.IsMatch(item.Text, "^[0-9]{1}"))
                        {
                            numeroCicli += int.Parse(item.Text.Substring(0, 1));
                        }
                        else
                        {
                            numeroCicli += 1;
                        }
                    }
                }
                l.Text = $"{numeroCicli}";
                //tot += Liste[i].Items.Count;
                i++;
            }
            int CarteSelezionate = 0;
            foreach (ListViewItem item in lvDeck.Items)
            {
                if (item.BackColor == Color.Green)
                {
                    CarteSelezionate++;
                }
            }
            lblTotalTags.Text = CarteSelezionate.ToString();
            lblTotalTags2.Text = CarteSelezionate.ToString();
            lblDeck.Text = ListeCard.Count.ToString();

        }
        private void lvDeck_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sender as Control, "Lista mazzo");
            TxtInfo.Text = "Click destro: elimina gli elementi selezionati\r\nClick sinistro + trascina: esporta carte con effetti comuni nei tag adiacenti";
            TxtInfo.AppendText("\r\nInvio: aggiungi carte selezionate al tag selezionato");
            TxtInfo.AppendText("\r\nCancel: rimuovi carte selezionate al tag selezionato");
            TxtInfo.AppendText("\r\n+: vai al tag successivo");
            TxtInfo.AppendText("\r\n-: vai al tag precedente");
        }

        private void txtsucc_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ListeLabelPerc)
            {
                item.Text += " !!";
                item.BackColor = Color.Orange;
            }
            TxtInfo.Text = "!!!!!!!!!!!!!!!!!!!Percentuale datata nelle tag!!!!!!!!!!!!!!!";
        }

        private void TTelimina_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sender as Control, "Elimina tutte le carte in questo tag");
        }
        private void TTPercentuale_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sender as Control, "Percentuale di trovare almeno una carta");
        }
        private void TTPNumero_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbColori_CheckedChanged(object sender, EventArgs e)
        {
            if (CbColori.Checked)
            {
                FLPCharts.Visible = true;
                FLPCharts.BringToFront();
                FLPCharts.Draggable(true);
                if (!Lightmode)
                {
                    chart1.BackColor = Color.DarkSlateBlue;
                    chart2.BackColor = Color.DarkSlateBlue;
                }
                CbColori.BackColor = Color.DarkGreen;
                CalcolaMostra();
            }
            else
            {
                FLPCharts.Visible = false;
                CbColori.BackColor = Color.DarkRed;
            }
        }
        public void CalcolaMostra()
        {
            int cartebrutte = 0;
            string nomecartebrutte = "";
            int CartaRossa = 0;
            int CartaBlu = 0;
            int CartaNera = 0;
            int CartaVerde = 0;
            int CartaBianca = 0;
            int ManaRosso = 0;
            int ManaBlu = 0;
            int ManaVerde = 0;
            int ManaNero = 0;
            int ManaBianco = 0;
            int nlande = 0;
            int ManaIncolore = 0;
            int cartaAttualeIndice = 0;
            foreach (Card carta in ListeCard)
            {
                if (StartSide > cartaAttualeIndice++)
                {

                    try//yes questo è il mio modo di evitare le carte doppie
                    {

                        if (carta.type_line.ToLower().Contains("land"))
                        {
                            nlande++;
                            //if (carta.oracle_text.Contains("{U}"))
                            //{
                            //    ManaBlu++;
                            //}
                            if (carta.oracle_text != null)
                            {
                                ManaIncolore += carta.oracle_text.Contains("{C}") ? 1 : 0;
                                ManaBlu += carta.oracle_text.Contains("{U}") ? 1 : 0;
                                ManaNero += carta.oracle_text.Contains("{B}") ? 1 : 0;
                                ManaVerde += carta.oracle_text.Contains("{G}") ? 1 : 0;
                                ManaRosso += carta.oracle_text.Contains("{R}") ? 1 : 0;
                                ManaBianco += carta.oracle_text.Contains("{W}") ? 1 : 0;
                                if (carta.oracle_text.ToLower().Contains("any color"))
                                {
                                    ManaBianco++;
                                    ManaBlu++;
                                    ManaRosso++;
                                    ManaNero++;
                                    ManaVerde++;
                                }
                                if (carta.oracle_text.ToLower().Contains("chosen color"))
                                {
                                    ManaBianco++;
                                    ManaBlu++;
                                    ManaRosso++;
                                    ManaNero++;
                                    ManaVerde++;
                                }
                                if (carta.oracle_text.ToLower().Contains("a basic land"))
                                {
                                    ManaBianco++;
                                    ManaBlu++;
                                    ManaRosso++;
                                    ManaNero++;
                                    ManaVerde++;
                                }
                            }
                            else//è una carta con 2 facce
                            {
                                foreach (CardFace FacciaCarta in carta.card_faces)
                                {
                                    if (FacciaCarta.type_line.ToLower()=="land")
                                    {
                                        ManaIncolore += FacciaCarta.oracle_text.Contains("{C}") ? 1 : 0;
                                        ManaBlu += FacciaCarta.oracle_text.Contains("{U}") ? 1 : 0;
                                        ManaNero += FacciaCarta.oracle_text.Contains("{B}") ? 1 : 0;
                                        ManaVerde += FacciaCarta.oracle_text.Contains("{G}") ? 1 : 0;
                                        ManaRosso += FacciaCarta.oracle_text.Contains("{R}") ? 1 : 0;
                                        ManaBianco += FacciaCarta.oracle_text.Contains("{W}") ? 1 : 0;
                                    }
                                    if (FacciaCarta.oracle_text.ToLower().Contains("any color"))
                                    {
                                        ManaBianco++;
                                        ManaBlu++;
                                        ManaRosso++;
                                        ManaNero++;
                                        ManaVerde++;
                                    }
                                    if (FacciaCarta.oracle_text.ToLower().Contains("chosen color"))
                                    {
                                        ManaBianco++;
                                        ManaBlu++;
                                        ManaRosso++;
                                        ManaNero++;
                                        ManaVerde++;
                                    }
                                    if (FacciaCarta.oracle_text.ToLower().Contains("a basic land"))
                                    {
                                        ManaBianco++;
                                        ManaBlu++;
                                        ManaRosso++;
                                        ManaNero++;
                                        ManaVerde++;
                                    }
                                }
                            }

                        }
                        else//fine mana prodotto da lande
                        {
                            if (carta.oracle_text != null)
                            {

                                CartaBianca += carta.mana_cost.ToUpper().Contains("W") ? 1 : 0;
                                CartaNera += carta.mana_cost.ToUpper().Contains("B") ? 1 : 0;
                                if (carta.mana_cost.ToUpper().Contains("U"))
                                {
                                    CartaBlu++;
                                }
                                //CartaBlu += carta.mana_cost.ToUpper().Contains("U") ? 1 : 0;
                                CartaVerde += carta.mana_cost.ToUpper().Contains("G") ? 1 : 0;
                                CartaRossa += carta.mana_cost.ToUpper().Contains("R") ? 1 : 0;
                            }
                            else
                            {
                                foreach (CardFace FacciaCarta in carta.card_faces)
                                {
                                    CartaBianca += FacciaCarta.mana_cost.ToUpper().Contains("W") ? 1 : 0;
                                    CartaNera += FacciaCarta.mana_cost.ToUpper().Contains("B") ? 1 : 0;
                                    CartaBlu += FacciaCarta.mana_cost.ToUpper().Contains("U") ? 1 : 0;
                                    CartaVerde += FacciaCarta.mana_cost.ToUpper().Contains("G") ? 1 : 0;
                                    CartaRossa += FacciaCarta.mana_cost.ToUpper().Contains("R") ? 1 : 0;
                                }
                            }
                        }
                        
                    }
                    catch (Exception error)
                    {
                        //se finisce qui è tendenzialmente per una carta doppia, quelle con due facce non quelle 
                        // che hanno // nel nome
                        nomecartebrutte += carta.name + "\r\n";
                        cartebrutte++;
                        continue;
                    }
                }

            }


            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart2.Series.Clear();
            chart2.Legends.Clear();
            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("MyLegend");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].BorderColor = Color.Black;
            //Add a new chart-series
            string seriesname = "% di terre che producono mana specifico";
            chart1.Series.Add(seriesname);
            chart1.Series[seriesname].IsValueShownAsLabel = true;
            chart1.Series[seriesname].LabelBackColor = Color.FromArgb(102, 102, 255);
            ////distribuzione colori lande
            int pos = 0;
            string[] colors = { "Blu", "Rosso", "Verde", "Nero", "Bianco", "Incolore" };
            Color[] colorVals = { Color.Blue, Color.Red, Color.Green, Color.Black, Color.Wheat, Color.Gray };
            int[] manaVals = { ManaBlu, ManaRosso, ManaVerde, ManaNero, ManaBianco, ManaIncolore };
            bool[] checkVals = { cbU.Checked, cbR.Checked, cbG.Checked, cbB.Checked, cbW.Checked, cbC.Checked };
            for (int i = 0; i < 6; i++)
            {
                if (manaVals[i] != 0 && checkVals[i])
                {
                    chart1.Series[seriesname].Points.AddXY(colors[i], (int)((float)manaVals[i] / nlande * 100));
                    chart1.Series[seriesname].Points[pos++].Color = colorVals[i];
                }
            }
            //Add a new Legend(if needed) and do some formating
            chart2.Legends.Add("MyLegend");
            chart2.Legends[0].LegendStyle = LegendStyle.Table;
            chart2.Legends[0].Docking = Docking.Bottom;
            chart2.Legends[0].Alignment = StringAlignment.Center;
            chart2.Legends[0].BorderColor = Color.Black;
            //Add a new chart-series
            var seriesname2 = "% di carte di colore specifico";
            chart2.Series.Add(seriesname2);
            chart2.Series[seriesname2].IsValueShownAsLabel = true;
            chart2.Series[seriesname2].LabelBackColor = Color.FromArgb(102, 102, 255);
            //distribuzione colori magie
            pos = 0;
            colors = new string[] { "blu", "Rosso", "Verde", "Nero", "Bianco" };
            Color[] colorsVals = new Color[] { Color.Blue, Color.Red, Color.Green, Color.Black, Color.Wheat };
            int[] cardVals = new int[] { CartaBlu, CartaRossa, CartaVerde, CartaNera, CartaBianca };
            for (int i = 0; i < colors.Length; i++)
            {
                if (cardVals[i] != 0)
                {
                    chart2.Series[seriesname2].Points.AddXY(colors[i], (int)((float)cardVals[i] / 99 * 100));
                    chart2.Series[seriesname2].Points[pos++].Color = colorsVals[i];
                }
            }
            if (cartebrutte != 0)
            {
                MessageBox.Show(cartebrutte + " carte non sono state contate (non ancora compatibili):\r\n" + nomecartebrutte, "Carte non trovate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CBSelezioneMultipla_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSelezioneMultipla.Checked)
            {
                // lvDeck.MultiSelect = true;
                CBSelezioneMultipla.BackColor = Color.DarkGreen;
                //controllo per le listview generate dentro a tutte le groupbox
                foreach (Control control in this.Controls)
                {
                    if (control is GroupBox)
                    {
                        foreach (Control childControl in control.Controls)
                        {
                            if (childControl is ListView)
                            {
                                (childControl as ListView).MultiSelect = true;
                            }
                        }
                    }
                }
            }
            else
            {
                // lvDeck.MultiSelect = false;
                CBSelezioneMultipla.BackColor = Color.DarkRed;
                //controllo per le listview generate dentro a tutte le groupbox
                foreach (Control control in this.Controls)
                {
                    //per ogni groupbox
                    if (control is GroupBox)
                    {
                        //per ogni oggetto dentro la groupbox
                        foreach (Control childControl in control.Controls)
                        {
                            //se è una listview allora...
                            if (childControl is ListView)
                            {
                                (childControl as ListView).MultiSelect = false;
                            }
                        }
                    }
                }
            }
        }

        private void txtsucc_MouseEnter(object sender, EventArgs e)
        {
            TxtInfo.Text = "numero carte interessate che vorresti vedere in mano";
        }

        private void txtci_MouseEnter(object sender, EventArgs e)
        {
            TxtInfo.Text = "numero carte interessate nel mazzo \r\n Esempio:se ti interessa sapere la probabilità di trovare una delle tue terre inserisci il numero di terre ";
        }

        private void lbldisplay_MouseEnter(object sender, EventArgs e)
        {
            TxtInfo.Text = "probabilità di trovare almeno il numero di carte che vuoi \r\n Esempio:se c'è 1 in 'carta che voglio' qui ti mostra la probabilità di trovarne almeno 1 ";
        }



        private void CalcolaMostra(object sender, EventArgs e)
        {
            CalcolaMostra();
        }

        private void BtnStampa_Click(object sender, EventArgs e)
        {
            // Create a new WebBrowser control
            System.Diagnostics.Process.Start("https://www.mtg-print.com/en-it");

        }

        private void BtnMox_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.moxfield.com/");
            btnCopia_Click(sender, e);
        }

        private void btnClip_MouseEnter(object sender, EventArgs e)
        {
            TxtInfo.Text = "Formato di esportazione mtgo(presente su moxfield) e cockatrice supportati. Esempio: \r\n 1 Solring \r\n 1 Time Wipe";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R) || keyData == (Keys.Control | Keys.Z))
            {
                //non funge, bho pd
                //IEnumerable<String> NomeCartePerse = cardNamesPrecedente.Except(cardNames);
                IEnumerable<Card> NomeCartePerse = ListeCardPrecedente.Except(ListeCard);
                string mazzo = "";
                foreach (Card NomeCarta in NomeCartePerse)
                {
                    mazzo += NomeCarta.name + "\r\n";
                }
                AggiungiADeck(mazzo, false);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Random()
        {
            try
            {

                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 3);
                string filePath = "";
                if (randomNumber == 1)
                {
                    filePath = @"Audio/male.wav";
                }
                else
                {
                    filePath = @"Audio/lol.wav";
                }
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(filePath);
                player.Play();
            }
            catch (Exception)
            {
            }
        }

        private void cbDrag_MouseEnter(object sender, EventArgs e)
        {
            TxtInfo.Text = "Risultato trascinabile\r\nClick Destro:Elimina ";
        }

        private void lvDeck_KeyPress(object sender, KeyPressEventArgs e)
        {
            //rimuove i suoni se magari premi k su una listview che non ha stringhe che iniziano con K
            //ha molti difetti, tipo disabilità il click sulla listview per selezionarla o il poter scrivere nelle
            //textbox
            e.Handled = true;

            try
            {

                switch (e.KeyChar)
                {
                    case (char)13://invio
                        try
                        {
                            ListView.SelectedListViewItemCollection selectedItems = lvDeck.SelectedItems;
                            ListViewItem[] items = new ListViewItem[selectedItems.Count];
                            selectedItems.CopyTo(items, 0);
                            TrasferisciInLV(ListaAttuale, items);
                        }
                        catch (Exception)
                        {
                            Random();
                            MessageBox.Show("Nessun tag selezionato");
                        }
                        break;
                    case (char)Keys.Back:
                        foreach (ListViewItem item in lvDeck.SelectedItems)
                        {
                            foreach (ListView lista in Liste)
                            {
                                foreach (ListViewItem carta in lista.Items)
                                {
                                    if (carta.Text.Trim().ToLower() == item.Text.ToLower().Trim())
                                    {
                                        lista.Items.Remove(carta);
                                        break;
                                    }
                                }
                            }
                            item.BackColor = DarkMode.BackColor;
                        }
                        AggiornaCounters();
                        break;
                    case (char)45://-
                        int TargetList = Liste.IndexOf(ListaAttuale);
                        if (--TargetList == 0)
                        {
                            TargetList = Liste.Count - 1;
                        }
                        Liste[Liste.IndexOf(ListaAttuale)].SelectedItems.Clear();
                        Colora(Liste[TargetList]);
                        Liste[TargetList].Items[0].Selected = true;
                        Liste[TargetList].Select();
                        Liste[TargetList].Select();
                        lvDeck.Select();
                        break;
                    case (char)43://+
                        int TargetLista = Liste.IndexOf(ListaAttuale);
                        int LO = Liste.Count;
                        if (++TargetLista == LO)
                        {
                            TargetLista = 1;
                        }
                        Colora(Liste[TargetLista]);
                        Liste[Liste.IndexOf(ListaAttuale)].SelectedItems.Clear();
                        Liste[TargetLista].Items[0].Selected = true;
                        Liste[TargetLista].Select();
                        Liste[TargetLista].Select();
                        lvDeck.Select();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        private void ChiudiColori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CbColori.Checked = false;
        }


        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            Point current = panel1.AutoScrollPosition;
            Point scrolled = new Point(current.X, -current.Y + 10);
            panel1.AutoScrollPosition = scrolled;
        }

        private void FLPCharts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CbColori.Checked = false;
            }
        }

        private void BtnImportaFile_Click(object sender, EventArgs e)
        {
            string configFolder = Directory.GetCurrentDirectory() + @"\Config";
            string configFile = Path.Combine(configFolder, "Config.txt");
            string initialDirectory = CreaCartellaIniziale(configFolder, configFile);

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = initialDirectory;
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //scrive dentro al file in config dove abbiamo letto questa volta per aprire da li la prox volta
                File.WriteAllText(configFile, Path.GetDirectoryName(openFileDialog1.FileName));
                ResetPanel();
                //puliamo tutto
                lvDeck.Items.Clear();
                ListeCard.Clear();
                foreach (ListView lista in Liste)
                {
                    lista.Clear();
                }
                AggiornaCounters();
                cardNames.Clear();
                //guardiamo cosa c'è nel file
                string fileName = openFileDialog1.FileName;
                string[] lines = File.ReadAllLines(fileName);
                File.WriteAllText(configFile, Path.GetDirectoryName(fileName));
                string[] carteAggiunte = new string[lines.Length];
                int p = 0;
                foreach (string line in lines)
                {
                    //toglie tutto ciò che c'è tra le parentesi ( ), comprese loro
                    //string linenopar = Regex.Replace(line, @"\(.*?\)", "");ù
                    int startIndex = line.IndexOf("(");
                    int endIndex = line.IndexOf("#");
                    string linenopar = line;
                    if (!(startIndex == -1 || endIndex == -1 || endIndex <= startIndex))
                    {
                        linenopar = linenopar.Remove(startIndex, endIndex - startIndex);
                    }
                    //string linenopar= Regex.Replace(line, @"\([^#]*#", "");
                    string[] parts = linenopar.Split('#');
                    string item = parts[0];
                    carteAggiunte[p++] = item;
                    for (int i = 1; i < parts.Length; i++)
                    {
                        string Tag = parts[i];

                        //rejex con tutte le parole possibili per indicare terra
                        string word = "#lande|#terre|#landa|#terra|#mana|#land";
                        string replacement = "#Land";
                        string tmp = line.ToLower().Trim();
                        //rimpiazza ogni istanza di word con il tag globale di moxifield per le lande
                        tmp = Regex.Replace(tmp, word, replacement, RegexOptions.IgnoreCase);
                        string[] tmpTags = tmp.Split('#');


                        bool stampa = true;
                        bool stampa2 = true;
                        if (Tag.Trim().ToLower() == "!land")
                        {
                            stampa = false;
                            foreach (string tagsss in tmpTags)
                            {
                                if (tagsss.Trim().ToLower() == "land")
                                {
                                    stampa2 = false;
                                }
                            }
                        }
                        // stampiamo se NON c'è il tag "!Land" o se c'è CON il tag Land
                        if ((stampa == false && stampa2) || (stampa && stampa2))
                        {
                            if (Liste.Count != 0)
                            {
                                int index = -1;
                                //cerchiamo in ogni lista txt
                                for (int j = 1; j < ListeTxt.Count; j++)
                                {
                                    //se ha il valore del tag cercato
                                    if (ListeTxt[j].Text.Trim().ToLower() == Tag.Trim().ToLower())
                                    {
                                        index = j;
                                        break;
                                    }//se non c'è o è uguale a ""
                                    else if (ListeTxt[j].Text == "" && index == -1)
                                    {
                                        index = j;
                                    }
                                }
                                if (index != -1)//lista trovata, metti li
                                {
                                    ListeTxt[index].Text = Tag;
                                    Liste[index].Items.Add(item);
                                }
                                if (index == -1)//lista non trovata, crea
                                {
                                    object s = new object();
                                    EventArgs eeee = new EventArgs();
                                    CreaTag_Click(s, eeee);
                                    ListeTxt[ListeTxt.Count - 1].Text = Tag;
                                    Liste[ListeTxt.Count - 1].Items.Add(item);
                                }
                            }
                            else
                            {//non esistono liste
                                object s = new object();
                                EventArgs eeee = new EventArgs();
                                CreaTag_Click(s, eeee);
                                ListeTxt[ListeTxt.Count - 1].Text = Tag;
                                Liste[ListeTxt.Count - 1].Items.Add(item);
                            }
                        }
                    }
                    //stampa
                    if (parts.Length == 1)//no tag
                        lvDeck.Items.Add(item);
                    else
                        lvDeck.Items.Add(item).BackColor = Color.Green;

                }
                ImportaCarte(carteAggiunte);
                AggiornaCounters();
            }
        }

        private static string CreaCartellaIniziale(string configFolder, string configFile)
        {
            //se non esiste crea la direcotry Config
            if (!Directory.Exists(configFolder))
                Directory.CreateDirectory(configFolder);
            string initialDirectory = @"C:";
            //se NON c'è il file ci si scrive dentro per crearlo altrimenti legge il contenuto per la initialDireco.
            if (!File.Exists(configFile))
                File.WriteAllText(configFile, configFolder);
            else
                initialDirectory = File.ReadAllText(configFile).Trim();
            return initialDirectory;
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            string configFolder = Directory.GetCurrentDirectory() + @"\Config";
            string configFile = Path.Combine(configFolder, "Deck.txt");
            string initialDirectory = CreaCartellaIniziale(configFolder, configFile);

            initialDirectory = File.ReadAllText(configFile).Trim();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = initialDirectory;
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.DefaultExt = "txt";
            //saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(configFile, Path.GetDirectoryName(saveFileDialog1.FileName));
                bool empty = panel1.Controls.OfType<TextBox>().Any(t => t != ListeTxt[0] && string.IsNullOrEmpty(t.Text));
                Dictionary<string, string> carteNumero = new Dictionary<string, string>();
                for (int i = 1; i < Liste.Count; i++)
                {
                    foreach (ListViewItem NomeCarta in Liste[i].Items)
                    {
                        //se non c'è lo mette nel dizionario altrimenti lo aggiunge al valore
                        carteNumero[NomeCarta.Text] = carteNumero.ContainsKey(NomeCarta.Text) ?
                        carteNumero[NomeCarta.Text] + "#" + ListeTxt[i].Text : "#" + ListeTxt[i].Text;
                    }
                }
                stringa = "";
                string stringaSide = "";
                foreach (var item in carteNumero)
                {
                    string value = item.Value.Trim().ToLower();
                    //se trovi la tag side mettile in una stringa a parte
                    if (item.Value.Trim().ToLower().Contains("side"))
                    {
                        stringaSide += item.Key + value.Replace("#sideboard", "").Replace("#side", "") + "\n";
                    }
                    else
                    {
                        //metti i tag globali se trovi terre
                        if (item.Value.Trim().ToLower().Contains("land"))
                        {
                            //rejex con tutte le parole possibili per indicare terra
                            string word = "#lande|#terre|#landa|#terra|#mana|#land|#!land|#!Land";
                            string replacement = "#!Land";
                            string tmp = item.Value.ToLower().Trim();
                            //rimpiazza ogni istanza di word con il tag globale di moxifield per le lande
                            tmp = Regex.Replace(tmp, word, replacement, RegexOptions.IgnoreCase);
                            //conta quante volte il tag globale è presente
                            int count = Regex.Matches(tmp, replacement).Count;
                            //rimuoviamo tutti i tag #!Land
                            tmp = tmp.Replace("#!Land", "");
                            //stampiamo per il numero di tag trovati
                            for (int i = 0; i < count; i++)
                            {
                                stringa += item.Key + tmp + "#!Land" + "\n";
                            }
                        }
                        else
                        {
                            //se non sono in side e non sono lande
                            stringa += item.Key + item.Value + "\n";
                        }
                    }
                }
                stringa = stringa.Replace("\n", "$");
                string[] stringhe = stringa.Split('$');
                File.WriteAllLines(saveFileDialog1.FileName, stringhe);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lande = new Lande(this);
            lande.Show();
        }

        private void BtnDorks_Click(object sender, EventArgs e)
        {
            var rocks = new RocksDorks(this);
            rocks.Show();
        }

        private void FLPCharts_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isResizeMode;
        private void FLPCharts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizeMode = true;
            }
        }

        private void FLPCharts_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizeMode)
            {
                this.Size = new Size(e.X, e.Y);
            }
        }

        private void FLPCharts_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizeMode = false;
            }
        }
    }
}
