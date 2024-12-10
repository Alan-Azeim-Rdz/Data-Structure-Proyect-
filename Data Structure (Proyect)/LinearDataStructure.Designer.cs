namespace Data_Structure__Proyect_
{
    partial class LinearDataStructure
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
            ListViewData = new ListView();
            BtnAddNumberList = new Button();
            TextNumberAdd = new TextBox();
            TextSizeVector = new TextBox();
            BtnSizeVector = new Button();
            LblSize = new Label();
            ComboBoxSelection = new ComboBox();
            ComboBoxStack = new ComboBox();
            ComboBoxQueuetype = new ComboBox();
            ComboBoxQueue = new ComboBox();
            ComboBoxList = new ComboBox();
            BtnAddNumberQueue = new Button();
            BtnAddNumberStack = new Button();
            SuspendLayout();
            // 
            // ListViewData
            // 
            ListViewData.Location = new Point(434, 12);
            ListViewData.Name = "ListViewData";
            ListViewData.Size = new Size(571, 575);
            ListViewData.TabIndex = 1;
            ListViewData.UseCompatibleStateImageBehavior = false;
            // 
            // BtnAddNumberList
            // 
            BtnAddNumberList.Location = new Point(59, 542);
            BtnAddNumberList.Name = "BtnAddNumberList";
            BtnAddNumberList.Size = new Size(75, 23);
            BtnAddNumberList.TabIndex = 6;
            BtnAddNumberList.Text = "Add";
            BtnAddNumberList.UseVisualStyleBackColor = true;
            BtnAddNumberList.Click += BtnAddNumber_Click;
            // 
            // TextNumberAdd
            // 
            TextNumberAdd.Location = new Point(93, 496);
            TextNumberAdd.Name = "TextNumberAdd";
            TextNumberAdd.Size = new Size(203, 23);
            TextNumberAdd.TabIndex = 7;
            // 
            // TextSizeVector
            // 
            TextSizeVector.Location = new Point(93, 352);
            TextSizeVector.Name = "TextSizeVector";
            TextSizeVector.Size = new Size(203, 23);
            TextSizeVector.TabIndex = 9;
            // 
            // BtnSizeVector
            // 
            BtnSizeVector.Location = new Point(12, 352);
            BtnSizeVector.Name = "BtnSizeVector";
            BtnSizeVector.Size = new Size(75, 23);
            BtnSizeVector.TabIndex = 8;
            BtnSizeVector.Text = "Create";
            BtnSizeVector.UseVisualStyleBackColor = true;
            BtnSizeVector.Click += BtnSizeVector_Click;
            // 
            // LblSize
            // 
            LblSize.AutoSize = true;
            LblSize.Location = new Point(12, 334);
            LblSize.Name = "LblSize";
            LblSize.Size = new Size(27, 15);
            LblSize.TabIndex = 10;
            LblSize.Text = "Size";
            // 
            // ComboBoxSelection
            // 
            ComboBoxSelection.FormattingEnabled = true;
            ComboBoxSelection.Items.AddRange(new object[] { "Listas", "Pilas", "Colas" });
            ComboBoxSelection.Location = new Point(12, 12);
            ComboBoxSelection.Name = "ComboBoxSelection";
            ComboBoxSelection.Size = new Size(156, 23);
            ComboBoxSelection.TabIndex = 11;
            ComboBoxSelection.Text = "Selection";
            ComboBoxSelection.SelectedIndexChanged += ComboBoxSelection_SelectedIndexChanged;
            // 
            // ComboBoxStack
            // 
            ComboBoxStack.FormattingEnabled = true;
            ComboBoxStack.Items.AddRange(new object[] { "arreglos", "Listas simples" });
            ComboBoxStack.Location = new Point(12, 143);
            ComboBoxStack.Name = "ComboBoxStack";
            ComboBoxStack.Size = new Size(156, 23);
            ComboBoxStack.TabIndex = 12;
            ComboBoxStack.Text = "Stack";
            // 
            // ComboBoxQueuetype
            // 
            ComboBoxQueuetype.FormattingEnabled = true;
            ComboBoxQueuetype.Items.AddRange(new object[] { "Vectores", "Listas " });
            ComboBoxQueuetype.Location = new Point(174, 102);
            ComboBoxQueuetype.Name = "ComboBoxQueuetype";
            ComboBoxQueuetype.Size = new Size(156, 23);
            ComboBoxQueuetype.TabIndex = 13;
            ComboBoxQueuetype.Text = "Queue Type";
            // 
            // ComboBoxQueue
            // 
            ComboBoxQueue.FormattingEnabled = true;
            ComboBoxQueue.Items.AddRange(new object[] { "Simples", "Circulares", "Dobles", "Prioridad" });
            ComboBoxQueue.Location = new Point(12, 102);
            ComboBoxQueue.Name = "ComboBoxQueue";
            ComboBoxQueue.Size = new Size(156, 23);
            ComboBoxQueue.TabIndex = 14;
            ComboBoxQueue.Text = "Queue";
            // 
            // ComboBoxList
            // 
            ComboBoxList.FormattingEnabled = true;
            ComboBoxList.Items.AddRange(new object[] { "Simples", "Circulares", "Dobles", "Dobles Circulares" });
            ComboBoxList.Location = new Point(12, 60);
            ComboBoxList.Name = "ComboBoxList";
            ComboBoxList.Size = new Size(156, 23);
            ComboBoxList.TabIndex = 15;
            ComboBoxList.Text = "List";
            ComboBoxList.SelectedIndexChanged += ComboBoxList_SelectedIndexChanged;
            // 
            // BtnAddNumberQueue
            // 
            BtnAddNumberQueue.Location = new Point(154, 542);
            BtnAddNumberQueue.Name = "BtnAddNumberQueue";
            BtnAddNumberQueue.Size = new Size(75, 23);
            BtnAddNumberQueue.TabIndex = 16;
            BtnAddNumberQueue.Text = "Enqueue";
            BtnAddNumberQueue.UseVisualStyleBackColor = true;
            BtnAddNumberQueue.Click += BtnAddNumberQueue_Click;
            // 
            // BtnAddNumberStack
            // 
            BtnAddNumberStack.Location = new Point(251, 542);
            BtnAddNumberStack.Name = "BtnAddNumberStack";
            BtnAddNumberStack.Size = new Size(75, 23);
            BtnAddNumberStack.TabIndex = 17;
            BtnAddNumberStack.Text = "Puhs";
            BtnAddNumberStack.UseVisualStyleBackColor = true;
            // 
            // LinearDataStructure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 629);
            Controls.Add(BtnAddNumberStack);
            Controls.Add(BtnAddNumberQueue);
            Controls.Add(ComboBoxList);
            Controls.Add(ComboBoxQueue);
            Controls.Add(ComboBoxQueuetype);
            Controls.Add(ComboBoxStack);
            Controls.Add(ComboBoxSelection);
            Controls.Add(LblSize);
            Controls.Add(TextSizeVector);
            Controls.Add(BtnSizeVector);
            Controls.Add(TextNumberAdd);
            Controls.Add(BtnAddNumberList);
            Controls.Add(ListViewData);
            Name = "LinearDataStructure";
            Text = "LinearDataStructure";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown DomainUpSelection;
        private ListView ListViewData;
        private DomainUpDown DomainUpList;
        private DomainUpDown DomainUp;
        private DomainUpDown DomainUpStack;
        private DomainUpDown DomainUpQueuetype;
        private Button BtnAddNumberList;
        private TextBox TextNumberAdd;
        private TextBox TextSizeVector;
        private Button BtnSizeVector;
        private Label LblSize;
        private ComboBox ComboBoxSelection;
        private ComboBox ComboBoxStack;
        private ComboBox ComboBoxQueuetype;
        private ComboBox ComboBoxQueue;
        private ComboBox ComboBoxList;
        private Button BtnAddNumberQueue;
        private Button BtnAddNumberStack;
    }
}