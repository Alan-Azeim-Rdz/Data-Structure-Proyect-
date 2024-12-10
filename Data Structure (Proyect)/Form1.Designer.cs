namespace Data_Structure__Proyect_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnDataStructure = new Button();
            BtnOrdenamentAlg = new Button();
            BtnSearchAlgorithms = new Button();
            SuspendLayout();
            // 
            // BtnDataStructure
            // 
            BtnDataStructure.Location = new Point(64, 108);
            BtnDataStructure.Name = "BtnDataStructure";
            BtnDataStructure.Size = new Size(159, 66);
            BtnDataStructure.TabIndex = 0;
            BtnDataStructure.Text = "Estructuras de datos Lineales";
            BtnDataStructure.UseVisualStyleBackColor = true;
            BtnDataStructure.Click += BtnDataStructure_Click;
            // 
            // BtnOrdenamentAlg
            // 
            BtnOrdenamentAlg.Location = new Point(298, 108);
            BtnOrdenamentAlg.Name = "BtnOrdenamentAlg";
            BtnOrdenamentAlg.Size = new Size(159, 66);
            BtnOrdenamentAlg.TabIndex = 1;
            BtnOrdenamentAlg.Text = "Algoritmos de Ordenamiento";
            BtnOrdenamentAlg.UseVisualStyleBackColor = true;
            BtnOrdenamentAlg.Click += BtnOrdenamentAlg_Click;
            // 
            // BtnSearchAlgorithms
            // 
            BtnSearchAlgorithms.Location = new Point(185, 253);
            BtnSearchAlgorithms.Name = "BtnSearchAlgorithms";
            BtnSearchAlgorithms.Size = new Size(159, 66);
            BtnSearchAlgorithms.TabIndex = 2;
            BtnSearchAlgorithms.Text = "Algoritmos de Ordenamiento";
            BtnSearchAlgorithms.UseVisualStyleBackColor = true;
            BtnSearchAlgorithms.Click += BtnSearchAlgorithms_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 423);
            Controls.Add(BtnSearchAlgorithms);
            Controls.Add(BtnOrdenamentAlg);
            Controls.Add(BtnDataStructure);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnDataStructure;
        private Button BtnOrdenamentAlg;
        private Button BtnSearchAlgorithms;
    }
}
