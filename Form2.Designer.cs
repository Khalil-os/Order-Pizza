namespace Pizza
{
    partial class OrderPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPizza));
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.gbWhereEat = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbWhereEat = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereEat.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Bauhaus 93", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(97, 162);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(169, 241);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Tag = "20";
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(14, 175);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(116, 40);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeduim.Location = new System.Drawing.Point(14, 119);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(154, 40);
            this.rbMeduim.TabIndex = 6;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Medium";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(14, 63);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(115, 40);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.cbGreenPeppers);
            this.gbToppings.Controls.Add(this.cbOnion);
            this.gbToppings.Controls.Add(this.cbOlives);
            this.gbToppings.Controls.Add(this.chTomatoes);
            this.gbToppings.Controls.Add(this.cbMushrooms);
            this.gbToppings.Controls.Add(this.cbCheese);
            this.gbToppings.Font = new System.Drawing.Font("Bauhaus 93", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(350, 162);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(525, 241);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "0";
            this.gbToppings.Text = "Toppings";
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.BackColor = System.Drawing.Color.Transparent;
            this.cbGreenPeppers.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGreenPeppers.Location = new System.Drawing.Point(263, 189);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(259, 40);
            this.cbGreenPeppers.TabIndex = 14;
            this.cbGreenPeppers.Tag = "5";
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = false;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.BackColor = System.Drawing.Color.Transparent;
            this.cbOnion.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnion.Location = new System.Drawing.Point(263, 128);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(131, 40);
            this.cbOnion.TabIndex = 13;
            this.cbOnion.Tag = "5";
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = false;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.BackColor = System.Drawing.Color.Transparent;
            this.cbOlives.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOlives.Location = new System.Drawing.Point(263, 67);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(131, 40);
            this.cbOlives.TabIndex = 12;
            this.cbOlives.Tag = "5";
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = false;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.BackColor = System.Drawing.Color.Transparent;
            this.chTomatoes.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTomatoes.Location = new System.Drawing.Point(17, 189);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(186, 40);
            this.chTomatoes.TabIndex = 11;
            this.chTomatoes.Tag = "5";
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = false;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.BackColor = System.Drawing.Color.Transparent;
            this.cbMushrooms.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMushrooms.Location = new System.Drawing.Point(17, 128);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(205, 40);
            this.cbMushrooms.TabIndex = 10;
            this.cbMushrooms.Tag = "5";
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = false;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.BackColor = System.Drawing.Color.Transparent;
            this.cbCheese.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheese.Location = new System.Drawing.Point(17, 67);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(240, 40);
            this.cbCheese.TabIndex = 9;
            this.cbCheese.Tag = "5";
            this.cbCheese.Text = "Extra Cheese";
            this.cbCheese.UseVisualStyleBackColor = false;
            this.cbCheese.CheckedChanged += new System.EventHandler(this.cbCheese_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.Controls.Add(this.rbThick);
            this.gbCrustType.Font = new System.Drawing.Font("Bauhaus 93", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(959, 162);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(457, 121);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Tag = "0";
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.BackColor = System.Drawing.Color.Transparent;
            this.rbThin.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(33, 66);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(99, 40);
            this.rbThin.TabIndex = 10;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = false;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.BackColor = System.Drawing.Color.Transparent;
            this.rbThick.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(224, 66);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(117, 40);
            this.rbThick.TabIndex = 9;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = false;
            this.rbThick.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // gbWhereEat
            // 
            this.gbWhereEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereEat.Controls.Add(this.rbEatIn);
            this.gbWhereEat.Controls.Add(this.rbEatOut);
            this.gbWhereEat.Font = new System.Drawing.Font("Bauhaus 93", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereEat.Location = new System.Drawing.Point(959, 289);
            this.gbWhereEat.Name = "gbWhereEat";
            this.gbWhereEat.Size = new System.Drawing.Size(457, 114);
            this.gbWhereEat.TabIndex = 4;
            this.gbWhereEat.TabStop = false;
            this.gbWhereEat.Text = "Where TO Eat ?";
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.BackColor = System.Drawing.Color.Transparent;
            this.rbEatIn.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(33, 62);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(119, 40);
            this.rbEatIn.TabIndex = 14;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = false;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.BackColor = System.Drawing.Color.Transparent;
            this.rbEatOut.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatOut.Location = new System.Drawing.Point(224, 62);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(170, 40);
            this.rbEatOut.TabIndex = 13;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Take Out";
            this.rbEatOut.UseVisualStyleBackColor = false;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lbWhereEat);
            this.groupBox5.Controls.Add(this.lbCrustType);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.lbSize);
            this.groupBox5.Controls.Add(this.label);
            this.groupBox5.Font = new System.Drawing.Font("Bauhaus 93", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Location = new System.Drawing.Point(967, 442);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(500, 569);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // lbWhereEat
            // 
            this.lbWhereEat.AutoSize = true;
            this.lbWhereEat.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold);
            this.lbWhereEat.ForeColor = System.Drawing.Color.White;
            this.lbWhereEat.Location = new System.Drawing.Point(288, 513);
            this.lbWhereEat.Name = "lbWhereEat";
            this.lbWhereEat.Size = new System.Drawing.Size(102, 36);
            this.lbWhereEat.TabIndex = 13;
            this.lbWhereEat.Text = "Eat In";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold);
            this.lbCrustType.ForeColor = System.Drawing.Color.White;
            this.lbCrustType.Location = new System.Drawing.Point(257, 450);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(166, 36);
            this.lbCrustType.TabIndex = 12;
            this.lbCrustType.Text = "Thin Crust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(43, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Where to eat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(43, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Crust Type:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbToppings);
            this.groupBox6.Location = new System.Drawing.Point(43, 136);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(424, 287);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Toppings";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold);
            this.lbToppings.ForeColor = System.Drawing.Color.White;
            this.lbToppings.Location = new System.Drawing.Point(32, 85);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(0, 28);
            this.lbToppings.TabIndex = 11;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbSize.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold);
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Location = new System.Drawing.Point(137, 85);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(95, 36);
            this.lbSize.TabIndex = 8;
            this.lbSize.Text = "Small";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(43, 85);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 36);
            this.label.TabIndex = 7;
            this.label.Text = "Size:";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.lbPrice);
            this.groupBox7.Font = new System.Drawing.Font("Bauhaus 93", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox7.Location = new System.Drawing.Point(34, 845);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(358, 166);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Total Price";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(99, 82);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(126, 63);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "$20";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(477, 917);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.BackColor = System.Drawing.Color.DarkOrange;
            this.btOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderPizza.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderPizza.Location = new System.Drawing.Point(722, 917);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(160, 73);
            this.btOrderPizza.TabIndex = 8;
            this.btOrderPizza.Text = "Done";
            this.btOrderPizza.UseVisualStyleBackColor = false;
            this.btOrderPizza.Click += new System.EventHandler(this.button2_Click);
            // 
            // OrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1621, 1044);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbWhereEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderPizza";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereEat.ResumeLayout(false);
            this.gbWhereEat.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox gbWhereEat;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbWhereEat;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Label lbPrice;
    }
}