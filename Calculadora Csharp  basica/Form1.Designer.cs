namespace Calculadora_Csharp__basica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInputTxt = new System.Windows.Forms.TextBox();
            this.CalculationResultTxt = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.ButtonMultiplication = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputTxt
            // 
            this.UserInputTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputTxt.Location = new System.Drawing.Point(13, 13);
            this.UserInputTxt.Name = "UserInputTxt";
            this.UserInputTxt.Size = new System.Drawing.Size(504, 20);
            this.UserInputTxt.TabIndex = 0;
            // 
            // CalculationResultTxt
            // 
            this.CalculationResultTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationResultTxt.Location = new System.Drawing.Point(13, 38);
            this.CalculationResultTxt.Name = "CalculationResultTxt";
            this.CalculationResultTxt.Size = new System.Drawing.Size(504, 57);
            this.CalculationResultTxt.TabIndex = 1;
            this.CalculationResultTxt.Text = "Please input an equation and press enter or =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.ButtonEquals, 3, 4);
            this.ButtonsPanel.Controls.Add(this.ButtonDot, 2, 4);
            this.ButtonsPanel.Controls.Add(this.Button0, 1, 4);
            this.ButtonsPanel.Controls.Add(this.ButtonPlus, 3, 3);
            this.ButtonsPanel.Controls.Add(this.Button3, 2, 3);
            this.ButtonsPanel.Controls.Add(this.Button2, 1, 3);
            this.ButtonsPanel.Controls.Add(this.Button1, 0, 3);
            this.ButtonsPanel.Controls.Add(this.ButtonMinus, 3, 2);
            this.ButtonsPanel.Controls.Add(this.Button6, 2, 2);
            this.ButtonsPanel.Controls.Add(this.Button5, 1, 2);
            this.ButtonsPanel.Controls.Add(this.Button4, 0, 2);
            this.ButtonsPanel.Controls.Add(this.ButtonMultiplication, 3, 1);
            this.ButtonsPanel.Controls.Add(this.Button9, 2, 1);
            this.ButtonsPanel.Controls.Add(this.Button8, 1, 1);
            this.ButtonsPanel.Controls.Add(this.Button7, 0, 1);
            this.ButtonsPanel.Controls.Add(this.Divide, 3, 0);
            this.ButtonsPanel.Controls.Add(this.Backspace, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(13, 98);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(504, 400);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEquals.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEquals.Location = new System.Drawing.Point(381, 323);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(120, 74);
            this.ButtonEquals.TabIndex = 19;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDot.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDot.Location = new System.Drawing.Point(255, 323);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(120, 74);
            this.ButtonDot.TabIndex = 18;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = true;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // Button0
            // 
            this.Button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button0.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button0.Location = new System.Drawing.Point(129, 323);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(120, 74);
            this.Button0.TabIndex = 17;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPlus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlus.Location = new System.Drawing.Point(381, 243);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(120, 74);
            this.ButtonPlus.TabIndex = 15;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // Button3
            // 
            this.Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(255, 243);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(120, 74);
            this.Button3.TabIndex = 14;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(129, 243);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(120, 74);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(3, 243);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(120, 74);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMinus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinus.Location = new System.Drawing.Point(381, 163);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(120, 74);
            this.ButtonMinus.TabIndex = 11;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // Button6
            // 
            this.Button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(255, 163);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(120, 74);
            this.Button6.TabIndex = 10;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(129, 163);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(120, 74);
            this.Button5.TabIndex = 9;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(3, 163);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(120, 74);
            this.Button4.TabIndex = 8;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMultiplication.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMultiplication.Location = new System.Drawing.Point(381, 83);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(120, 74);
            this.ButtonMultiplication.TabIndex = 7;
            this.ButtonMultiplication.Text = "×";
            this.ButtonMultiplication.UseVisualStyleBackColor = true;
            this.ButtonMultiplication.Click += new System.EventHandler(this.ButtonMultiplication_Click);
            // 
            // Button9
            // 
            this.Button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.Location = new System.Drawing.Point(255, 83);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(120, 74);
            this.Button9.TabIndex = 6;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.Location = new System.Drawing.Point(129, 83);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(120, 74);
            this.Button8.TabIndex = 5;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(3, 83);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(120, 74);
            this.Button7.TabIndex = 4;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Divide
            // 
            this.Divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divide.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(381, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(120, 74);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Backspace
            // 
            this.Backspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backspace.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backspace.Location = new System.Drawing.Point(255, 3);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(120, 74);
            this.Backspace.TabIndex = 2;
            this.Backspace.Text = "Del";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(120, 74);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.ButtonEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(529, 510);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultTxt);
            this.Controls.Add(this.UserInputTxt);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputTxt;
        private System.Windows.Forms.Label CalculationResultTxt;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button ButtonMultiplication;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
    }
}

