using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Invoice : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-7C8TE05;DataBase=BookShop;Integrated Security=true");
        string LPC;

        public Invoice()
        {
            InitializeComponent();
        }
        public Invoice(string lpc)
        {
            this.LPC = lpc;
            InitializeComponent();
        }


        public Invoice(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10, string v11, string v12, string v13, string v14, string v15, string v16, string v17, string v18, string v19, string v20, string v21, string v22, string v23, string v24, string v25, string v26, string v27, string v28, string v29, string v30, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
            this.V4 = v4;
            this.V5 = v5;
            this.V6 = v6;
            this.V7 = v7;
            this.V8 = v8;
            this.V9 = v9;
            this.V10 = v10;
            this.V11 = v11;
            this.V12 = v12;
            this.V13 = v13;
            this.V14 = v14;
            this.V15 = v15;
            this.V16 = v16;
            this.V17 = v17;
            this.V18 = v18;
            this.V19 = v19;
            this.V20 = v20;
            this.V21 = v21;
            this.V22 = v22;
            this.V23 = v23;
            this.V24 = v24;
            this.V25 = v25;
            this.V26 = v26;
            this.V27 = v27;
            this.V28 = v28;
            this.V29 = v29;
            this.V30 = v30;

            this.LPT = lpt;

            InitializeComponent();
        }

        public Invoice(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v11, string v12, string v13, string v14, string v15, string v16, string v17, string v18, string v19, string v21, string v22, string v23, string v24, string v25, string v26, string v27, string v28, string v29, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
            this.V4 = v4;
            this.V5 = v5;
            this.V6 = v6;
            this.V7 = v7;
            this.V8 = v8;
            this.V9 = v9;

            this.V11 = v11;
            this.V12 = v12;
            this.V13 = v13;
            this.V14 = v14;
            this.V15 = v15;
            this.V16 = v16;
            this.V17 = v17;
            this.V18 = v18;
            this.V19 = v19;


            this.V21 = v21;
            this.V22 = v22;
            this.V23 = v23;
            this.V24 = v24;
            this.V25 = v25;
            this.V26 = v26;
            this.V27 = v27;
            this.V28 = v28;
            this.V29 = v29;

            this.LPT = lpt;

            InitializeComponent();
        }


        public Invoice(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v11, string v12, string v13, string v14, string v15, string v16, string v17, string v18, string v21, string v22, string v23, string v24, string v25, string v26, string v27, string v28, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
            this.V4 = v4;
            this.V5 = v5;
            this.V6 = v6;
            this.V7 = v7;
            this.V8 = v8;


            this.V11 = v11;
            this.V12 = v12;
            this.V13 = v13;
            this.V14 = v14;
            this.V15 = v15;
            this.V16 = v16;
            this.V17 = v17;
            this.V18 = v18;



            this.V21 = v21;
            this.V22 = v22;
            this.V23 = v23;
            this.V24 = v24;
            this.V25 = v25;
            this.V26 = v26;
            this.V27 = v27;
            this.V28 = v28;

            this.LPT = lpt;


            InitializeComponent();
        }

        public Invoice(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v11, string v12, string v13, string v14, string v15, string v16, string v17, string v21, string v22, string v23, string v24, string v25, string v26, string v27, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
            this.V4 = v4;
            this.V5 = v5;
            this.V6 = v6;
            this.V7 = v7;


            this.V11 = v11;
            this.V12 = v12;
            this.V13 = v13;
            this.V14 = v14;
            this.V15 = v15;
            this.V16 = v16;
            this.V17 = v17;



            this.V21 = v21;
            this.V22 = v22;
            this.V23 = v23;
            this.V24 = v24;
            this.V25 = v25;
            this.V26 = v26;
            this.V27 = v27;
            this.LPT = lpt;


            InitializeComponent();
        }

        public Invoice(string v1, string v2, string v3, string v4, string v5, string v6, string v11, string v12, string v13, string v14, string v15, string v16, string v21, string v22, string v23, string v24, string v25, string v26, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
            this.V4 = v4;
            this.V5 = v5;
            this.V6 = v6;


            this.V11 = v11;
            this.V12 = v12;
            this.V13 = v13;
            this.V14 = v14;
            this.V15 = v15;
            this.V16 = v16;



            this.V21 = v21;
            this.V22 = v22;
            this.V23 = v23;
            this.V24 = v24;
            this.V25 = v25;
            this.V26 = v26;
            this.LPT = lpt;


            InitializeComponent();
        }
        public Invoice(string v1, string v2, string v3, string v4, string v5, string v11, string v12, string v13, string v14, string v15, string v21, string v22, string v23, string v24, string v25, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
            this.V4 = v4;
            this.V5 = v5;


            this.V11 = v11;
            this.V12 = v12;
            this.V13 = v13;
            this.V14 = v14;
            this.V15 = v15;



            this.V21 = v21;
            this.V22 = v22;
            this.V23 = v23;
            this.V24 = v24;
            this.V25 = v25;
            this.LPT = lpt;


            InitializeComponent();
        }
        public Invoice(string v1, string v2, string v3, string v4, string v11, string v12, string v13, string v14, string v21, string v22, string v23, string v24, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
            this.V4 = v4;


            this.V11 = v11;
            this.V12 = v12;
            this.V13 = v13;
            this.V14 = v14;



            this.V21 = v21;
            this.V22 = v22;
            this.V23 = v23;
            this.V24 = v24;
            this.LPT = lpt;


            InitializeComponent();
        }

        public Invoice(string v1, string v2, string v3, string v11, string v12, string v13, string v21, string v22, string v23, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;


            this.V11 = v11;
            this.V12 = v12;
            this.V13 = v13;



            this.V21 = v21;
            this.V22 = v22;
            this.V23 = v23;
            this.LPT = lpt;


            InitializeComponent();
        }
        public Invoice(string v1, string v2, string v11, string v12, string v21, string v22, string lpt)
        {
            this.V1 = v1;
            this.V2 = v2;


            this.V11 = v11;
            this.V12 = v12;



            this.V21 = v21;
            this.V22 = v22;
            this.LPT = lpt;


            InitializeComponent();
        }



        public Invoice(string v1, string v11, string v21, string lpt)
        {
            this.V1 = v1;

            this.V11 = v11;

            this.V21 = v21;
            this.LPT = lpt;

            InitializeComponent();
        }

        public string V1 { get; set; }
        public string V2 { get; set; }
        public string V3 { get; set; }
        public string V4 { get; set; }
        public string V5 { get; set; }
        public string V6 { get; set; }
        public string V7 { get; set; }
        public string V8 { get; set; }
        public string V9 { get; set; }
        public string V10 { get; set; }
        public string V11 { get; set; }
        public string V12 { get; set; }
        public string V13 { get; set; }
        public string V14 { get; set; }
        public string V15 { get; set; }
        public string V16 { get; set; }
        public string V17 { get; set; }
        public string V18 { get; set; }
        public string V19 { get; set; }
        public string V20 { get; set; }
        public string V21 { get; set; }
        public string V22 { get; set; }
        public string V23 { get; set; }
        public string V24 { get; set; }
        public string V25 { get; set; }
        public string V26 { get; set; }
        public string V27 { get; set; }
        public string V28 { get; set; }
        public string V29 { get; set; }
        public string V30 { get; set; }
        public string LPT { get; set; }










        private void Invoice_Load(object sender, EventArgs e)
        {
            labeld.Text = DateTime.Now.ToString();

            label1.Text = V1;
            label2.Text = V2;
            label3.Text = V3;
            label4.Text = V4;
            label5.Text = V5;
            label6.Text = V6;
            label7.Text = V7;
            label8.Text = V8;
            label9.Text = V9;
            label10.Text = V10;
            label11.Text = V11;
            label12.Text = V12;
            label13.Text = V13;
            label14.Text = V14;
            label15.Text = V15;
            label16.Text = V16;
            label17.Text = V17;
            label18.Text = V18;
            label19.Text = V19;
            label20.Text = V20;
            label21.Text = V21;
            label22.Text = V22;
            label23.Text = V23;
            label24.Text = V24;
            label25.Text = V25;
            label26.Text = V26;
            label27.Text = V27;
            label28.Text = V28;
            label29.Text = V29;
            label30.Text = V30;
            label35.Text = LPT;
        }
    }
}
