
namespace Fase2_Aula04_AppBanco
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.listExtratos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extrato bancário";
            // 
            // listExtratos
            // 
            this.listExtratos.HideSelection = false;
            this.listExtratos.Location = new System.Drawing.Point(54, 130);
            this.listExtratos.Name = "listExtratos";
            this.listExtratos.Size = new System.Drawing.Size(219, 163);
            this.listExtratos.TabIndex = 3;
            this.listExtratos.UseCompatibleStateImageBehavior = false;
            this.listExtratos.View = System.Windows.Forms.View.List;
            this.listExtratos.SelectedIndexChanged += new System.EventHandler(this.listExtratos_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listExtratos);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Extrat";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listExtratos;
    }
}