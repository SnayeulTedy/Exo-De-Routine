namespace unPetitExoSympa
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
            this.lb_LeftList = new System.Windows.Forms.ListBox();
            this.lb_RightList = new System.Windows.Forms.ListBox();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.btnAddLeftList = new System.Windows.Forms.Button();
            this.btn_RemoveLeftElt = new System.Windows.Forms.Button();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.btn_RemoveRightElement = new System.Windows.Forms.Button();
            this.btn_AddListRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Quit = new System.Windows.Forms.Button();
            this.bt_LefttoRight = new System.Windows.Forms.Button();
            this.bt_RighttoLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_LeftList
            // 
            this.lb_LeftList.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LeftList.FormattingEnabled = true;
            this.lb_LeftList.ItemHeight = 21;
            this.lb_LeftList.Location = new System.Drawing.Point(34, 106);
            this.lb_LeftList.Name = "lb_LeftList";
            this.lb_LeftList.Size = new System.Drawing.Size(233, 256);
            this.lb_LeftList.Sorted = true;
            this.lb_LeftList.TabIndex = 0;
            // 
            // lb_RightList
            // 
            this.lb_RightList.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RightList.FormattingEnabled = true;
            this.lb_RightList.ItemHeight = 21;
            this.lb_RightList.Location = new System.Drawing.Point(387, 106);
            this.lb_RightList.Name = "lb_RightList";
            this.lb_RightList.Size = new System.Drawing.Size(233, 256);
            this.lb_RightList.TabIndex = 0;
            // 
            // tbLeft
            // 
            this.tbLeft.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLeft.Location = new System.Drawing.Point(34, 395);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(227, 23);
            this.tbLeft.TabIndex = 1;
            // 
            // btnAddLeftList
            // 
            this.btnAddLeftList.BackColor = System.Drawing.Color.White;
            this.btnAddLeftList.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLeftList.Location = new System.Drawing.Point(34, 430);
            this.btnAddLeftList.Name = "btnAddLeftList";
            this.btnAddLeftList.Size = new System.Drawing.Size(105, 58);
            this.btnAddLeftList.TabIndex = 2;
            this.btnAddLeftList.Text = "+";
            this.btnAddLeftList.UseVisualStyleBackColor = false;
            this.btnAddLeftList.Click += new System.EventHandler(this.btnAddLeftList_Click);
            // 
            // btn_RemoveLeftElt
            // 
            this.btn_RemoveLeftElt.BackColor = System.Drawing.Color.White;
            this.btn_RemoveLeftElt.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveLeftElt.Location = new System.Drawing.Point(162, 430);
            this.btn_RemoveLeftElt.Name = "btn_RemoveLeftElt";
            this.btn_RemoveLeftElt.Size = new System.Drawing.Size(105, 58);
            this.btn_RemoveLeftElt.TabIndex = 2;
            this.btn_RemoveLeftElt.Text = "-";
            this.btn_RemoveLeftElt.UseVisualStyleBackColor = false;
            this.btn_RemoveLeftElt.Click += new System.EventHandler(this.btn_RemoveLeftElt_Click);
            // 
            // tbRight
            // 
            this.tbRight.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRight.Location = new System.Drawing.Point(393, 395);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(227, 23);
            this.tbRight.TabIndex = 1;
            // 
            // btn_RemoveRightElement
            // 
            this.btn_RemoveRightElement.BackColor = System.Drawing.Color.White;
            this.btn_RemoveRightElement.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveRightElement.Location = new System.Drawing.Point(515, 430);
            this.btn_RemoveRightElement.Name = "btn_RemoveRightElement";
            this.btn_RemoveRightElement.Size = new System.Drawing.Size(105, 58);
            this.btn_RemoveRightElement.TabIndex = 2;
            this.btn_RemoveRightElement.Text = "-";
            this.btn_RemoveRightElement.UseVisualStyleBackColor = false;
            this.btn_RemoveRightElement.Click += new System.EventHandler(this.btn_RemoveRightElement_Click);
            // 
            // btn_AddListRight
            // 
            this.btn_AddListRight.BackColor = System.Drawing.Color.White;
            this.btn_AddListRight.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddListRight.Location = new System.Drawing.Point(387, 430);
            this.btn_AddListRight.Name = "btn_AddListRight";
            this.btn_AddListRight.Size = new System.Drawing.Size(105, 58);
            this.btn_AddListRight.TabIndex = 2;
            this.btn_AddListRight.Text = "+";
            this.btn_AddListRight.UseVisualStyleBackColor = false;
            this.btn_AddListRight.Click += new System.EventHandler(this.btn_AddListRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Un Petit Exo Simpa";
            // 
            // bt_Quit
            // 
            this.bt_Quit.BackColor = System.Drawing.Color.Navy;
            this.bt_Quit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Quit.ForeColor = System.Drawing.Color.White;
            this.bt_Quit.Location = new System.Drawing.Point(283, 519);
            this.bt_Quit.Name = "bt_Quit";
            this.bt_Quit.Size = new System.Drawing.Size(93, 47);
            this.bt_Quit.TabIndex = 4;
            this.bt_Quit.Text = "Quitter";
            this.bt_Quit.UseVisualStyleBackColor = false;
            this.bt_Quit.Click += new System.EventHandler(this.bt_Quit_Click);
            // 
            // bt_LefttoRight
            // 
            this.bt_LefttoRight.BackColor = System.Drawing.Color.White;
            this.bt_LefttoRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LefttoRight.Location = new System.Drawing.Point(283, 144);
            this.bt_LefttoRight.Name = "bt_LefttoRight";
            this.bt_LefttoRight.Size = new System.Drawing.Size(88, 39);
            this.bt_LefttoRight.TabIndex = 4;
            this.bt_LefttoRight.Text = ">>";
            this.bt_LefttoRight.UseVisualStyleBackColor = false;
            this.bt_LefttoRight.Click += new System.EventHandler(this.bt_LefttoRight_Click);
            // 
            // bt_RighttoLeft
            // 
            this.bt_RighttoLeft.BackColor = System.Drawing.Color.White;
            this.bt_RighttoLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RighttoLeft.Location = new System.Drawing.Point(283, 206);
            this.bt_RighttoLeft.Name = "bt_RighttoLeft";
            this.bt_RighttoLeft.Size = new System.Drawing.Size(88, 39);
            this.bt_RighttoLeft.TabIndex = 4;
            this.bt_RighttoLeft.Text = "<<";
            this.bt_RighttoLeft.UseVisualStyleBackColor = false;
            this.bt_RighttoLeft.Click += new System.EventHandler(this.bt_RighttoLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(667, 577);
            this.Controls.Add(this.bt_RighttoLeft);
            this.Controls.Add(this.bt_LefttoRight);
            this.Controls.Add(this.bt_Quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RemoveRightElement);
            this.Controls.Add(this.btn_RemoveLeftElt);
            this.Controls.Add(this.btn_AddListRight);
            this.Controls.Add(this.btnAddLeftList);
            this.Controls.Add(this.tbRight);
            this.Controls.Add(this.tbLeft);
            this.Controls.Add(this.lb_RightList);
            this.Controls.Add(this.lb_LeftList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_LeftList;
        private System.Windows.Forms.ListBox lb_RightList;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.Button btnAddLeftList;
        private System.Windows.Forms.Button btn_RemoveLeftElt;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.Button btn_RemoveRightElement;
        private System.Windows.Forms.Button btn_AddListRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Quit;
        private System.Windows.Forms.Button bt_LefttoRight;
        private System.Windows.Forms.Button bt_RighttoLeft;
    }
}

