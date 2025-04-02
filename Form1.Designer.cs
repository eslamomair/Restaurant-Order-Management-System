namespace Restaurant_order_management_system
{
    partial class Form1
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
            this.btnCoffe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnLargPizza = new System.Windows.Forms.Button();
            this.btnPurger = new System.Windows.Forms.Button();
            this.btnGlassOfWater = new System.Windows.Forms.Button();
            this.btnMilk = new System.Windows.Forms.Button();
            this.btnSmallPizza = new System.Windows.Forms.Button();
            this.btnMeduiemPizza = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReseat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCoffe
            // 
            this.btnCoffe.Location = new System.Drawing.Point(276, 34);
            this.btnCoffe.Name = "btnCoffe";
            this.btnCoffe.Size = new System.Drawing.Size(206, 70);
            this.btnCoffe.TabIndex = 0;
            this.btnCoffe.Tag = "100";
            this.btnCoffe.Text = "Coffe";
            this.btnCoffe.UseVisualStyleBackColor = true;
            this.btnCoffe.Click += new System.EventHandler(this.AllCLick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btnTea);
            this.groupBox1.Controls.Add(this.btnLargPizza);
            this.groupBox1.Controls.Add(this.btnPurger);
            this.groupBox1.Controls.Add(this.btnGlassOfWater);
            this.groupBox1.Controls.Add(this.btnMilk);
            this.groupBox1.Controls.Add(this.btnSmallPizza);
            this.groupBox1.Controls.Add(this.btnMeduiemPizza);
            this.groupBox1.Controls.Add(this.btnCoffe);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnTea
            // 
            this.btnTea.Location = new System.Drawing.Point(276, 356);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(206, 70);
            this.btnTea.TabIndex = 9;
            this.btnTea.Tag = "10";
            this.btnTea.Text = "Tea";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.AllCLick);
            // 
            // btnLargPizza
            // 
            this.btnLargPizza.Location = new System.Drawing.Point(15, 249);
            this.btnLargPizza.Name = "btnLargPizza";
            this.btnLargPizza.Size = new System.Drawing.Size(206, 70);
            this.btnLargPizza.TabIndex = 8;
            this.btnLargPizza.Tag = "300";
            this.btnLargPizza.Text = "Pizza Larg";
            this.btnLargPizza.UseVisualStyleBackColor = true;
            this.btnLargPizza.Click += new System.EventHandler(this.AllCLick);
            // 
            // btnPurger
            // 
            this.btnPurger.Location = new System.Drawing.Point(15, 356);
            this.btnPurger.Name = "btnPurger";
            this.btnPurger.Size = new System.Drawing.Size(206, 70);
            this.btnPurger.TabIndex = 7;
            this.btnPurger.Tag = "200";
            this.btnPurger.Text = "Purger";
            this.btnPurger.UseVisualStyleBackColor = true;
            this.btnPurger.Click += new System.EventHandler(this.AllCLick);
            // 
            // btnGlassOfWater
            // 
            this.btnGlassOfWater.Location = new System.Drawing.Point(276, 135);
            this.btnGlassOfWater.Name = "btnGlassOfWater";
            this.btnGlassOfWater.Size = new System.Drawing.Size(206, 70);
            this.btnGlassOfWater.TabIndex = 5;
            this.btnGlassOfWater.Tag = "50";
            this.btnGlassOfWater.Text = "Glass Of Water";
            this.btnGlassOfWater.UseVisualStyleBackColor = true;
            this.btnGlassOfWater.Click += new System.EventHandler(this.AllCLick);
            // 
            // btnMilk
            // 
            this.btnMilk.Location = new System.Drawing.Point(276, 249);
            this.btnMilk.Name = "btnMilk";
            this.btnMilk.Size = new System.Drawing.Size(206, 70);
            this.btnMilk.TabIndex = 4;
            this.btnMilk.Tag = "25";
            this.btnMilk.Text = "Milk";
            this.btnMilk.UseVisualStyleBackColor = true;
            this.btnMilk.Click += new System.EventHandler(this.AllCLick);
            // 
            // btnSmallPizza
            // 
            this.btnSmallPizza.Location = new System.Drawing.Point(15, 34);
            this.btnSmallPizza.Name = "btnSmallPizza";
            this.btnSmallPizza.Size = new System.Drawing.Size(206, 70);
            this.btnSmallPizza.TabIndex = 2;
            this.btnSmallPizza.Tag = "500";
            this.btnSmallPizza.Text = "Pizza Smal";
            this.btnSmallPizza.UseVisualStyleBackColor = true;
            this.btnSmallPizza.Click += new System.EventHandler(this.AllCLick);
            // 
            // btnMeduiemPizza
            // 
            this.btnMeduiemPizza.Location = new System.Drawing.Point(15, 135);
            this.btnMeduiemPizza.Name = "btnMeduiemPizza";
            this.btnMeduiemPizza.Size = new System.Drawing.Size(206, 70);
            this.btnMeduiemPizza.TabIndex = 1;
            this.btnMeduiemPizza.Tag = "400";
            this.btnMeduiemPizza.Text = "Pizza Mediuem";
            this.btnMeduiemPizza.UseVisualStyleBackColor = true;
            this.btnMeduiemPizza.Click += new System.EventHandler(this.AllCLick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.btnReseat);
            this.groupBox2.Controls.Add(this.btnOrder);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblPrize);
            this.groupBox2.Controls.Add(this.lblOrder);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(510, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 462);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(12, 64);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(304, 255);
            this.lblOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Summary";
            // 
            // lblPrize
            // 
            this.lblPrize.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPrize.Location = new System.Drawing.Point(108, 340);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(121, 62);
            this.lblPrize.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prize";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(254, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 62);
            this.label4.TabIndex = 4;
            this.label4.Text = "$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOrder.Location = new System.Drawing.Point(16, 419);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 37);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order Now";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReseat
            // 
            this.btnReseat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReseat.Location = new System.Drawing.Point(189, 420);
            this.btnReseat.Name = "btnReseat";
            this.btnReseat.Size = new System.Drawing.Size(113, 37);
            this.btnReseat.TabIndex = 6;
            this.btnReseat.Text = "Reaset";
            this.btnReseat.UseVisualStyleBackColor = true;
            this.btnReseat.Click += new System.EventHandler(this.btnReseat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoffe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnLargPizza;
        private System.Windows.Forms.Button btnPurger;
        private System.Windows.Forms.Button btnGlassOfWater;
        private System.Windows.Forms.Button btnMilk;
        private System.Windows.Forms.Button btnSmallPizza;
        private System.Windows.Forms.Button btnMeduiemPizza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReseat;
    }
}

