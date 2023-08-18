namespace x.o.x;

public partial class Form1 : Form
{
        int berabere=0;
        bool siraX;
        bool siraY;
        public Form1()
        {
           
            InitializeComponent();
        }
        public void xKazandi()
        {
            //yatayda ara
            if(button1.Text=="X" && button2.Text=="X" && button3.Text == "X")
            {
                
                this.label1.Font = new Font("Calibri", 30);
                label1.Text = "kazanan X";
                siraX = false;
                siraY=false;
                berabere=1;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label1.Text = "kazanan X";
                siraX = false;
                siraY = false;
                 berabere=1;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label1.Text = "kazanan X";
                siraX = false;
                siraY = false;
                 berabere=1;
            }
            //dikey ara
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label1.Text = "kazanan X";
                siraX = false;
                siraY = false;
                berabere=1;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label1.Text = "kazanan X";
                siraX = false;
                siraY = false;
                berabere=1;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label1.Text = "kazanan X";
                siraX = false;
                siraY = false;
                 berabere=1;
            }

            //capraz ara
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = "kazanan X";
                siraX = false;
                siraY = false;
                berabere=1;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = "kazanan X";
                siraX = false;
                siraY = false;
                berabere=1;
            }
            //o için 
            //yatayda ara
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label1.Text = "kazanan O";
                siraX = false;
                siraY = false;
               berabere=1;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label1.Text = "kazanan O";
                siraX = false;
                siraY = false;
                berabere=1;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label1.Text = "kazanan O";
                siraX = false;
                siraY = false;
               berabere=1;
            }
            //dikey ara
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label1.Text = "kazanan O";
                siraX = false;
                siraY = false;
                 berabere=1;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label1.Text = "kazanan O";
                siraX = false;
                siraY = false;
                 berabere=1;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label1.Text = "kazanan O";
                siraX = false;
                siraY = false;
                berabere=1;
            }

            //capraz ara
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label1.Text = "kazanan O";
                siraX = false;
                siraY = false;
                 berabere=1;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label1.Text = "kazanan O";
                siraX = false;
                siraY = false;
                berabere=1;
            }
             if(button1.Enabled==false && button2.Enabled==false && button3.Enabled==false && button4.Enabled==false && button5.Enabled==false && button6.Enabled==false && button7.Enabled==false && button8.Enabled==false && button9.Enabled==false && berabere==0)
            {
                label1.Text="Oyun berabere bitti.";
                
            }
           

        }

        private void hangiButon(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (siraX)
            { 
                label1.Text = "Sira O'da";
                siraX = false;
                siraY = true;
                x.Text = "X";
                x.Enabled = false;
                x.BackColor = Color.Pink;
                xKazandi();
                
            }
            else if(siraY)
            {
                label1.Text = "Sira X'te";
                siraX = true;
                siraY = false;
                x.Text = "O";
                x.Enabled = false;
                x.BackColor = Color.Purple;
                xKazandi();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void xbutonu(object sender, EventArgs e)
        {
     
            siraX = true;
            button10.Enabled = false;
            button11.Enabled = false;
            label1.Text = "Sira X'te";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            siraY = true;
            button11.Enabled = false;
            button10.Enabled = false;
            label1.Text = "Sira O'da";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = ""; 
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            siraY = false;
            siraX = false;
            label1.Text = "birinci oyuncu için karakter seçin";
            button1.UseVisualStyleBackColor = true;
            button2.UseVisualStyleBackColor = true;
            button3.UseVisualStyleBackColor = true;
            button4.UseVisualStyleBackColor = true;
            button5.UseVisualStyleBackColor = true;
            button6.UseVisualStyleBackColor = true;
            button7.UseVisualStyleBackColor = true;
            button8.UseVisualStyleBackColor = true;
            button9.UseVisualStyleBackColor = true;
            berabere=0;
            label1.Font = new Font("Calibri", 10);
        }
    }
