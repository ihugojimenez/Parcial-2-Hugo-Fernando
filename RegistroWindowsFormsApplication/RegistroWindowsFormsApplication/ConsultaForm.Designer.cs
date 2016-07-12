namespace RegistroWindowsFormsApplication
{
    partial class ConsultaForm
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
            this.ConsultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultButton
            // 
            this.ConsultButton.Location = new System.Drawing.Point(343, 69);
            this.ConsultButton.Name = "ConsultButton";
            this.ConsultButton.Size = new System.Drawing.Size(86, 35);
            this.ConsultButton.TabIndex = 1;
            this.ConsultButton.Text = "Consultar";
            this.ConsultButton.UseVisualStyleBackColor = true;
            this.ConsultButton.Click += new System.EventHandler(this.ConsultButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar Empleados";
            // 
            // ConsultDataGridView
            // 
            this.ConsultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultDataGridView.Location = new System.Drawing.Point(12, 110);
            this.ConsultDataGridView.Name = "ConsultDataGridView";
            this.ConsultDataGridView.RowTemplate.Height = 24;
            this.ConsultDataGridView.Size = new System.Drawing.Size(716, 216);
            this.ConsultDataGridView.TabIndex = 3;
            // 
            // ConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 352);
            this.Controls.Add(this.ConsultDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultButton);
            this.Name = "ConsultaForm";
            this.Text = "ConsultaForm";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConsultButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsultDataGridView;
    }
}