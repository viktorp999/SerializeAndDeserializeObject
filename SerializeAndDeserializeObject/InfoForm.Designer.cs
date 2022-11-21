
namespace SerializeAndDeserializeObject
{
    partial class InfoForm
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
            this.AdressInput = new System.Windows.Forms.TextBox();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameL = new System.Windows.Forms.Label();
            this.LastNameL = new System.Windows.Forms.Label();
            this.CityL = new System.Windows.Forms.Label();
            this.AdressL = new System.Windows.Forms.Label();
            this.TeenagerCheck = new System.Windows.Forms.CheckBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.OpenB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdressInput
            // 
            this.AdressInput.Location = new System.Drawing.Point(188, 265);
            this.AdressInput.Name = "AdressInput";
            this.AdressInput.Size = new System.Drawing.Size(100, 20);
            this.AdressInput.TabIndex = 0;
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(188, 199);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(100, 20);
            this.CityInput.TabIndex = 1;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(188, 144);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(100, 20);
            this.LastNameInput.TabIndex = 2;
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(188, 80);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(100, 20);
            this.FirstNameInput.TabIndex = 3;
            // 
            // FirstNameL
            // 
            this.FirstNameL.AutoSize = true;
            this.FirstNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameL.Location = new System.Drawing.Point(81, 74);
            this.FirstNameL.Name = "FirstNameL";
            this.FirstNameL.Size = new System.Drawing.Size(101, 25);
            this.FirstNameL.TabIndex = 4;
            this.FirstNameL.Text = "FirstName";
            // 
            // LastNameL
            // 
            this.LastNameL.AutoSize = true;
            this.LastNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameL.Location = new System.Drawing.Point(81, 139);
            this.LastNameL.Name = "LastNameL";
            this.LastNameL.Size = new System.Drawing.Size(101, 25);
            this.LastNameL.TabIndex = 5;
            this.LastNameL.Text = "LastName";
            // 
            // CityL
            // 
            this.CityL.AutoSize = true;
            this.CityL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityL.Location = new System.Drawing.Point(81, 199);
            this.CityL.Name = "CityL";
            this.CityL.Size = new System.Drawing.Size(46, 25);
            this.CityL.TabIndex = 6;
            this.CityL.Text = "City";
            // 
            // AdressL
            // 
            this.AdressL.AutoSize = true;
            this.AdressL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressL.Location = new System.Drawing.Point(81, 259);
            this.AdressL.Name = "AdressL";
            this.AdressL.Size = new System.Drawing.Size(74, 25);
            this.AdressL.TabIndex = 7;
            this.AdressL.Text = "Adress";
            // 
            // TeenagerCheck
            // 
            this.TeenagerCheck.AutoSize = true;
            this.TeenagerCheck.Location = new System.Drawing.Point(188, 315);
            this.TeenagerCheck.Name = "TeenagerCheck";
            this.TeenagerCheck.Size = new System.Drawing.Size(89, 17);
            this.TeenagerCheck.TabIndex = 8;
            this.TeenagerCheck.Text = "Is Teenager?";
            this.TeenagerCheck.UseVisualStyleBackColor = true;
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(86, 356);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 12;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveFile);
            // 
            // OpenB
            // 
            this.OpenB.Location = new System.Drawing.Point(188, 356);
            this.OpenB.Name = "OpenB";
            this.OpenB.Size = new System.Drawing.Size(75, 23);
            this.OpenB.TabIndex = 13;
            this.OpenB.Text = "Open";
            this.OpenB.UseVisualStyleBackColor = true;
            this.OpenB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenFile);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 411);
            this.Controls.Add(this.OpenB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.TeenagerCheck);
            this.Controls.Add(this.AdressL);
            this.Controls.Add(this.CityL);
            this.Controls.Add(this.LastNameL);
            this.Controls.Add(this.FirstNameL);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.AdressInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FirstNameL;
        private System.Windows.Forms.Label LastNameL;
        private System.Windows.Forms.Label CityL;
        private System.Windows.Forms.Label AdressL;
        private System.Windows.Forms.Button SaveB;
        public System.Windows.Forms.TextBox AdressInput;
        public System.Windows.Forms.TextBox CityInput;
        public System.Windows.Forms.TextBox LastNameInput;
        public System.Windows.Forms.TextBox FirstNameInput;
        public System.Windows.Forms.CheckBox TeenagerCheck;
        private System.Windows.Forms.Button OpenB;
    }
}

