namespace ivs_proj_2_calc
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.resultBox = new System.Windows.Forms.TextBox();
            this.lbl_history = new System.Windows.Forms.TextBox();
            this.btn_root = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_comma = new System.Windows.Forms.Button();
            this.btn_num_0 = new System.Windows.Forms.Button();
            this.btn_num_3 = new System.Windows.Forms.Button();
            this.btn_num_2 = new System.Windows.Forms.Button();
            this.btn_num_1 = new System.Windows.Forms.Button();
            this.btn_num_6 = new System.Windows.Forms.Button();
            this.btn_num_5 = new System.Windows.Forms.Button();
            this.btn_num_4 = new System.Windows.Forms.Button();
            this.btn_num_9 = new System.Windows.Forms.Button();
            this.btn_num_8 = new System.Windows.Forms.Button();
            this.btn_num_7 = new System.Windows.Forms.Button();
            this.labelHistory = new System.Windows.Forms.Label();
            this.btn_napoveda = new System.Windows.Forms.Button();
            this.btn_neg = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_fact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultBox.Location = new System.Drawing.Point(6, 161);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultBox.ShortcutsEnabled = false;
            this.resultBox.Size = new System.Drawing.Size(407, 56);
            this.resultBox.TabIndex = 5000;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_history
            // 
            this.lbl_history.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_history.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_history.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_history.Location = new System.Drawing.Point(10, 35);
            this.lbl_history.Multiline = true;
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.ReadOnly = true;
            this.lbl_history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbl_history.ShortcutsEnabled = false;
            this.lbl_history.Size = new System.Drawing.Size(403, 110);
            this.lbl_history.TabIndex = 6000;
            this.lbl_history.TabStop = false;
            // 
            // btn_root
            // 
            this.btn_root.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_root.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_root.Location = new System.Drawing.Point(11, 228);
            this.btn_root.Name = "btn_root";
            this.btn_root.Size = new System.Drawing.Size(100, 60);
            this.btn_root.TabIndex = 78;
            this.btn_root.TabStop = false;
            this.btn_root.Text = "√";
            this.btn_root.UseVisualStyleBackColor = false;
            this.btn_root.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_del.CausesValidation = false;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_del.Location = new System.Drawing.Point(209, 228);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 60);
            this.btn_del.TabIndex = 400;
            this.btn_del.TabStop = false;
            this.btn_del.Text = "C";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ce.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ce.Location = new System.Drawing.Point(110, 228);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(100, 60);
            this.btn_ce.TabIndex = 75;
            this.btn_ce.TabStop = false;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = false;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_div.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_div.Location = new System.Drawing.Point(308, 287);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(100, 60);
            this.btn_div.TabIndex = 74;
            this.btn_div.TabStop = false;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_enter.Location = new System.Drawing.Point(308, 523);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(100, 60);
            this.btn_enter.TabIndex = 70;
            this.btn_enter.TabStop = false;
            this.btn_enter.Tag = "0";
            this.btn_enter.Text = "=";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_add.Location = new System.Drawing.Point(308, 464);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 60);
            this.btn_add.TabIndex = 69;
            this.btn_add.TabStop = false;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sub.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_sub.Location = new System.Drawing.Point(308, 405);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(100, 60);
            this.btn_sub.TabIndex = 68;
            this.btn_sub.TabStop = false;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mul.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_mul.Location = new System.Drawing.Point(308, 346);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(100, 60);
            this.btn_mul.TabIndex = 67;
            this.btn_mul.TabStop = false;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_comma
            // 
            this.btn_comma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comma.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_comma.Location = new System.Drawing.Point(209, 523);
            this.btn_comma.Name = "btn_comma";
            this.btn_comma.Size = new System.Drawing.Size(100, 60);
            this.btn_comma.TabIndex = 66;
            this.btn_comma.TabStop = false;
            this.btn_comma.Text = ",";
            this.btn_comma.UseVisualStyleBackColor = false;
            this.btn_comma.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_0
            // 
            this.btn_num_0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_0.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_0.Location = new System.Drawing.Point(110, 523);
            this.btn_num_0.Name = "btn_num_0";
            this.btn_num_0.Size = new System.Drawing.Size(100, 60);
            this.btn_num_0.TabIndex = 65;
            this.btn_num_0.TabStop = false;
            this.btn_num_0.Text = "0";
            this.btn_num_0.UseVisualStyleBackColor = false;
            this.btn_num_0.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_3
            // 
            this.btn_num_3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_3.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_3.Location = new System.Drawing.Point(209, 464);
            this.btn_num_3.Name = "btn_num_3";
            this.btn_num_3.Size = new System.Drawing.Size(100, 60);
            this.btn_num_3.TabIndex = 64;
            this.btn_num_3.TabStop = false;
            this.btn_num_3.Text = "3";
            this.btn_num_3.UseVisualStyleBackColor = false;
            this.btn_num_3.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_2
            // 
            this.btn_num_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_2.Location = new System.Drawing.Point(110, 464);
            this.btn_num_2.Name = "btn_num_2";
            this.btn_num_2.Size = new System.Drawing.Size(100, 60);
            this.btn_num_2.TabIndex = 63;
            this.btn_num_2.TabStop = false;
            this.btn_num_2.Text = "2";
            this.btn_num_2.UseVisualStyleBackColor = false;
            this.btn_num_2.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_1
            // 
            this.btn_num_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_1.Location = new System.Drawing.Point(11, 464);
            this.btn_num_1.Name = "btn_num_1";
            this.btn_num_1.Size = new System.Drawing.Size(100, 60);
            this.btn_num_1.TabIndex = 62;
            this.btn_num_1.TabStop = false;
            this.btn_num_1.Text = "1";
            this.btn_num_1.UseVisualStyleBackColor = false;
            this.btn_num_1.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_6
            // 
            this.btn_num_6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_6.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_6.Location = new System.Drawing.Point(209, 405);
            this.btn_num_6.Name = "btn_num_6";
            this.btn_num_6.Size = new System.Drawing.Size(100, 60);
            this.btn_num_6.TabIndex = 61;
            this.btn_num_6.TabStop = false;
            this.btn_num_6.Text = "6";
            this.btn_num_6.UseVisualStyleBackColor = false;
            this.btn_num_6.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_5
            // 
            this.btn_num_5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_5.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_5.Location = new System.Drawing.Point(110, 405);
            this.btn_num_5.Name = "btn_num_5";
            this.btn_num_5.Size = new System.Drawing.Size(100, 60);
            this.btn_num_5.TabIndex = 60;
            this.btn_num_5.TabStop = false;
            this.btn_num_5.Text = "5";
            this.btn_num_5.UseVisualStyleBackColor = false;
            this.btn_num_5.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_4
            // 
            this.btn_num_4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_4.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_4.Location = new System.Drawing.Point(11, 405);
            this.btn_num_4.Name = "btn_num_4";
            this.btn_num_4.Size = new System.Drawing.Size(100, 60);
            this.btn_num_4.TabIndex = 59;
            this.btn_num_4.TabStop = false;
            this.btn_num_4.Text = "4";
            this.btn_num_4.UseVisualStyleBackColor = false;
            this.btn_num_4.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_9
            // 
            this.btn_num_9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_9.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_9.Location = new System.Drawing.Point(209, 346);
            this.btn_num_9.Name = "btn_num_9";
            this.btn_num_9.Size = new System.Drawing.Size(100, 60);
            this.btn_num_9.TabIndex = 58;
            this.btn_num_9.TabStop = false;
            this.btn_num_9.Text = "9";
            this.btn_num_9.UseVisualStyleBackColor = false;
            this.btn_num_9.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_8
            // 
            this.btn_num_8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_8.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_8.Location = new System.Drawing.Point(110, 346);
            this.btn_num_8.Name = "btn_num_8";
            this.btn_num_8.Size = new System.Drawing.Size(100, 60);
            this.btn_num_8.TabIndex = 57;
            this.btn_num_8.TabStop = false;
            this.btn_num_8.Text = "8";
            this.btn_num_8.UseVisualStyleBackColor = false;
            this.btn_num_8.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_7
            // 
            this.btn_num_7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_num_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num_7.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_num_7.Location = new System.Drawing.Point(11, 346);
            this.btn_num_7.Name = "btn_num_7";
            this.btn_num_7.Size = new System.Drawing.Size(100, 60);
            this.btn_num_7.TabIndex = 56;
            this.btn_num_7.TabStop = false;
            this.btn_num_7.Text = "7";
            this.btn_num_7.UseVisualStyleBackColor = false;
            this.btn_num_7.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelHistory.Location = new System.Drawing.Point(12, 8);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(99, 24);
            this.labelHistory.TabIndex = 6001;
            this.labelHistory.Text = "História:";
            // 
            // btn_napoveda
            // 
            this.btn_napoveda.FlatAppearance.BorderSize = 0;
            this.btn_napoveda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_napoveda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_napoveda.Location = new System.Drawing.Point(334, 2);
            this.btn_napoveda.Name = "btn_napoveda";
            this.btn_napoveda.Size = new System.Drawing.Size(79, 30);
            this.btn_napoveda.TabIndex = 6002;
            this.btn_napoveda.TabStop = false;
            this.btn_napoveda.Text = "Nápoveda";
            this.btn_napoveda.UseVisualStyleBackColor = true;
            this.btn_napoveda.Click += new System.EventHandler(this.btn_napoveda_Click);
            // 
            // btn_neg
            // 
            this.btn_neg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_neg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_neg.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_neg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_neg.Image = global::ivs_proj_2_calc.Properties.Resources.icons8_plus_minus_50;
            this.btn_neg.Location = new System.Drawing.Point(11, 523);
            this.btn_neg.Name = "btn_neg";
            this.btn_neg.Size = new System.Drawing.Size(100, 60);
            this.btn_neg.TabIndex = 77;
            this.btn_neg.TabStop = false;
            this.btn_neg.Text = "+-";
            this.btn_neg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_neg.UseVisualStyleBackColor = false;
            this.btn_neg.Click += new System.EventHandler(this.btn_neg_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backspace.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_backspace.Image = ((System.Drawing.Image)(resources.GetObject("btn_backspace.Image")));
            this.btn_backspace.Location = new System.Drawing.Point(308, 228);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(100, 60);
            this.btn_backspace.TabIndex = 76;
            this.btn_backspace.TabStop = false;
            this.btn_backspace.UseVisualStyleBackColor = false;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sqrt.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_sqrt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sqrt.Image = global::ivs_proj_2_calc.Properties.Resources.iconfinder_square;
            this.btn_sqrt.Location = new System.Drawing.Point(209, 287);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(100, 60);
            this.btn_sqrt.TabIndex = 73;
            this.btn_sqrt.TabStop = false;
            this.btn_sqrt.UseVisualStyleBackColor = false;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exp.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_exp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exp.Image = global::ivs_proj_2_calc.Properties.Resources.iconfinder_power;
            this.btn_exp.Location = new System.Drawing.Point(110, 287);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(100, 60);
            this.btn_exp.TabIndex = 72;
            this.btn_exp.TabStop = false;
            this.btn_exp.Text = "^";
            this.btn_exp.UseVisualStyleBackColor = false;
            this.btn_exp.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_fact
            // 
            this.btn_fact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_fact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fact.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_fact.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_fact.Image = global::ivs_proj_2_calc.Properties.Resources.iconfinder_factorial;
            this.btn_fact.Location = new System.Drawing.Point(11, 287);
            this.btn_fact.Name = "btn_fact";
            this.btn_fact.Size = new System.Drawing.Size(100, 60);
            this.btn_fact.TabIndex = 71;
            this.btn_fact.TabStop = false;
            this.btn_fact.Text = "!";
            this.btn_fact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fact.UseVisualStyleBackColor = false;
            this.btn_fact.Click += new System.EventHandler(this.btn_fact_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 591);
            this.Controls.Add(this.btn_napoveda);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.btn_root);
            this.Controls.Add(this.btn_neg);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_fact);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_comma);
            this.Controls.Add(this.btn_num_0);
            this.Controls.Add(this.btn_num_3);
            this.Controls.Add(this.btn_num_2);
            this.Controls.Add(this.btn_num_1);
            this.Controls.Add(this.btn_num_6);
            this.Controls.Add(this.btn_num_5);
            this.Controls.Add(this.btn_num_4);
            this.Controls.Add(this.btn_num_9);
            this.Controls.Add(this.btn_num_8);
            this.Controls.Add(this.btn_num_7);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.resultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Kalkulačka";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox lbl_history;
        private System.Windows.Forms.Button btn_root;
        private System.Windows.Forms.Button btn_neg;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_fact;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_comma;
        private System.Windows.Forms.Button btn_num_0;
        private System.Windows.Forms.Button btn_num_3;
        private System.Windows.Forms.Button btn_num_2;
        private System.Windows.Forms.Button btn_num_1;
        private System.Windows.Forms.Button btn_num_6;
        private System.Windows.Forms.Button btn_num_5;
        private System.Windows.Forms.Button btn_num_4;
        private System.Windows.Forms.Button btn_num_9;
        private System.Windows.Forms.Button btn_num_8;
        private System.Windows.Forms.Button btn_num_7;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Button btn_napoveda;
    }
}

