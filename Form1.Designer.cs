namespace Dinamic
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGVResult = new System.Windows.Forms.DataGridView();
            this.solutionTab = new System.Windows.Forms.TabPage();
            this.matchLB = new System.Windows.Forms.Label();
            this.sequenceLB = new System.Windows.Forms.Label();
            this.resultLB = new System.Windows.Forms.Label();
            this.dataGVRevenue = new System.Windows.Forms.DataGridView();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCreate = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.investmentsPortionsLB = new System.Windows.Forms.Label();
            this.projectsCountLB = new System.Windows.Forms.Label();
            this.totalAmountLB = new System.Windows.Forms.Label();
            this.investmentsPortionsTB = new System.Windows.Forms.TextBox();
            this.projectsCountTB = new System.Windows.Forms.TextBox();
            this.totalAmountTB = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inputDataTab = new System.Windows.Forms.TabPage();
            this.sequenceInvestmentsLB = new System.Windows.Forms.Label();
            this.sequenceInvestmentsTB = new System.Windows.Forms.TextBox();
            this.tableLB = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVResult)).BeginInit();
            this.solutionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRevenue)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.inputDataTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGVResult
            // 
            this.dataGVResult.AllowUserToAddRows = false;
            this.dataGVResult.AllowUserToDeleteRows = false;
            this.dataGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVResult.Location = new System.Drawing.Point(12, 34);
            this.dataGVResult.Name = "dataGVResult";
            this.dataGVResult.ReadOnly = true;
            this.dataGVResult.RowHeadersWidth = 51;
            this.dataGVResult.RowTemplate.Height = 29;
            this.dataGVResult.Size = new System.Drawing.Size(643, 380);
            this.dataGVResult.TabIndex = 6;
            // 
            // solutionTab
            // 
            this.solutionTab.Controls.Add(this.matchLB);
            this.solutionTab.Controls.Add(this.sequenceLB);
            this.solutionTab.Controls.Add(this.resultLB);
            this.solutionTab.Controls.Add(this.dataGVResult);
            this.solutionTab.Location = new System.Drawing.Point(4, 29);
            this.solutionTab.Name = "solutionTab";
            this.solutionTab.Size = new System.Drawing.Size(1168, 513);
            this.solutionTab.TabIndex = 2;
            this.solutionTab.Text = "Решение";
            this.solutionTab.UseVisualStyleBackColor = true;
            // 
            // matchLB
            // 
            this.matchLB.AutoSize = true;
            this.matchLB.Location = new System.Drawing.Point(672, 63);
            this.matchLB.Name = "matchLB";
            this.matchLB.Size = new System.Drawing.Size(37, 20);
            this.matchLB.TabIndex = 9;
            this.matchLB.Text = "x.. f..";
            // 
            // sequenceLB
            // 
            this.sequenceLB.AutoSize = true;
            this.sequenceLB.Location = new System.Drawing.Point(12, 11);
            this.sequenceLB.Name = "sequenceLB";
            this.sequenceLB.Size = new System.Drawing.Size(73, 20);
            this.sequenceLB.TabIndex = 8;
            this.sequenceLB.Text = "Sequence";
            // 
            // resultLB
            // 
            this.resultLB.AutoSize = true;
            this.resultLB.Location = new System.Drawing.Point(672, 34);
            this.resultLB.Name = "resultLB";
            this.resultLB.Size = new System.Drawing.Size(55, 20);
            this.resultLB.TabIndex = 7;
            this.resultLB.Text = "F(x..x...)";
            // 
            // dataGVRevenue
            // 
            this.dataGVRevenue.AllowUserToAddRows = false;
            this.dataGVRevenue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVRevenue.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGVRevenue.Location = new System.Drawing.Point(3, 57);
            this.dataGVRevenue.Margin = new System.Windows.Forms.Padding(3, 3, 12, 12);
            this.dataGVRevenue.Name = "dataGVRevenue";
            this.dataGVRevenue.RowHeadersWidth = 51;
            this.dataGVRevenue.RowTemplate.Height = 29;
            this.dataGVRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGVRevenue.Size = new System.Drawing.Size(729, 445);
            this.dataGVRevenue.TabIndex = 0;
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDelete.Text = "Очистить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonCreate
            // 
            this.toolStripButtonCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreate.Image")));
            this.toolStripButtonCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreate.Name = "toolStripButtonCreate";
            this.toolStripButtonCreate.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCreate.Text = "Создать";
            this.toolStripButtonCreate.Click += new System.EventHandler(this.toolStripButtonCreate_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(1054, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(935, 220);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 29);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // investmentsPortionsLB
            // 
            this.investmentsPortionsLB.AutoSize = true;
            this.investmentsPortionsLB.Enabled = false;
            this.investmentsPortionsLB.Location = new System.Drawing.Point(747, 138);
            this.investmentsPortionsLB.Name = "investmentsPortionsLB";
            this.investmentsPortionsLB.Size = new System.Drawing.Size(175, 20);
            this.investmentsPortionsLB.TabIndex = 7;
            this.investmentsPortionsLB.Text = "Порции инвестиций, ед";
            // 
            // projectsCountLB
            // 
            this.projectsCountLB.AutoSize = true;
            this.projectsCountLB.Enabled = false;
            this.projectsCountLB.Location = new System.Drawing.Point(763, 52);
            this.projectsCountLB.Name = "projectsCountLB";
            this.projectsCountLB.Size = new System.Drawing.Size(159, 40);
            this.projectsCountLB.TabIndex = 6;
            this.projectsCountLB.Text = "Количество проектов\r\nдля инвестиций";
            // 
            // totalAmountLB
            // 
            this.totalAmountLB.AutoSize = true;
            this.totalAmountLB.Enabled = false;
            this.totalAmountLB.Location = new System.Drawing.Point(787, 103);
            this.totalAmountLB.Name = "totalAmountLB";
            this.totalAmountLB.Size = new System.Drawing.Size(135, 20);
            this.totalAmountLB.TabIndex = 5;
            this.totalAmountLB.Text = "Сумма средств, ед";
            // 
            // investmentsPortionsTB
            // 
            this.investmentsPortionsTB.Enabled = false;
            this.investmentsPortionsTB.Location = new System.Drawing.Point(929, 135);
            this.investmentsPortionsTB.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.investmentsPortionsTB.Name = "investmentsPortionsTB";
            this.investmentsPortionsTB.Size = new System.Drawing.Size(225, 27);
            this.investmentsPortionsTB.TabIndex = 4;
            this.investmentsPortionsTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.investmentsPortionsTB_KeyDown);
            this.investmentsPortionsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.investmentsPortionsTB_KeyPress);
            // 
            // projectsCountTB
            // 
            this.projectsCountTB.Enabled = false;
            this.projectsCountTB.Location = new System.Drawing.Point(929, 65);
            this.projectsCountTB.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.projectsCountTB.Name = "projectsCountTB";
            this.projectsCountTB.Size = new System.Drawing.Size(225, 27);
            this.projectsCountTB.TabIndex = 3;
            this.projectsCountTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.projectsCountTB_KeyDown);
            this.projectsCountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.projectsCountTB_KeyPress);
            // 
            // totalAmountTB
            // 
            this.totalAmountTB.Enabled = false;
            this.totalAmountTB.Location = new System.Drawing.Point(929, 100);
            this.totalAmountTB.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.totalAmountTB.Name = "totalAmountTB";
            this.totalAmountTB.Size = new System.Drawing.Size(225, 27);
            this.totalAmountTB.TabIndex = 2;
            this.totalAmountTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totalAmountTB_KeyDown);
            this.totalAmountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalAmountTB_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCreate,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1162, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEdit.Text = "Редактировать входные данные";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // inputDataTab
            // 
            this.inputDataTab.Controls.Add(this.sequenceInvestmentsLB);
            this.inputDataTab.Controls.Add(this.sequenceInvestmentsTB);
            this.inputDataTab.Controls.Add(this.tableLB);
            this.inputDataTab.Controls.Add(this.cancelButton);
            this.inputDataTab.Controls.Add(this.applyButton);
            this.inputDataTab.Controls.Add(this.investmentsPortionsLB);
            this.inputDataTab.Controls.Add(this.projectsCountLB);
            this.inputDataTab.Controls.Add(this.totalAmountLB);
            this.inputDataTab.Controls.Add(this.investmentsPortionsTB);
            this.inputDataTab.Controls.Add(this.projectsCountTB);
            this.inputDataTab.Controls.Add(this.totalAmountTB);
            this.inputDataTab.Controls.Add(this.toolStrip1);
            this.inputDataTab.Controls.Add(this.dataGVRevenue);
            this.inputDataTab.Location = new System.Drawing.Point(4, 29);
            this.inputDataTab.Name = "inputDataTab";
            this.inputDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputDataTab.Size = new System.Drawing.Size(1168, 513);
            this.inputDataTab.TabIndex = 0;
            this.inputDataTab.Text = "Входные данные";
            this.inputDataTab.UseVisualStyleBackColor = true;
            // 
            // sequenceInvestmentsLB
            // 
            this.sequenceInvestmentsLB.AutoSize = true;
            this.sequenceInvestmentsLB.Enabled = false;
            this.sequenceInvestmentsLB.Location = new System.Drawing.Point(768, 170);
            this.sequenceInvestmentsLB.Name = "sequenceInvestmentsLB";
            this.sequenceInvestmentsLB.Size = new System.Drawing.Size(154, 40);
            this.sequenceInvestmentsLB.TabIndex = 12;
            this.sequenceInvestmentsLB.Text = "Последовательность\r\nинвестиций";
            // 
            // sequenceInvestmentsTB
            // 
            this.sequenceInvestmentsTB.Enabled = false;
            this.sequenceInvestmentsTB.Location = new System.Drawing.Point(929, 170);
            this.sequenceInvestmentsTB.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.sequenceInvestmentsTB.Name = "sequenceInvestmentsTB";
            this.sequenceInvestmentsTB.Size = new System.Drawing.Size(225, 27);
            this.sequenceInvestmentsTB.TabIndex = 11;
            this.sequenceInvestmentsTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sequenceInvestmentsTB_KeyDown);
            this.sequenceInvestmentsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sequenceInvestmentsTB_KeyPress);
            // 
            // tableLB
            // 
            this.tableLB.AutoSize = true;
            this.tableLB.Location = new System.Drawing.Point(6, 34);
            this.tableLB.Name = "tableLB";
            this.tableLB.Size = new System.Drawing.Size(289, 20);
            this.tableLB.TabIndex = 10;
            this.tableLB.Text = "Прибыль от вложения в каждый проект";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.inputDataTab);
            this.tabControl.Controls.Add(this.solutionTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1176, 546);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.getSolution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 569);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Investments";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVResult)).EndInit();
            this.solutionTab.ResumeLayout(false);
            this.solutionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRevenue)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.inputDataTab.ResumeLayout(false);
            this.inputDataTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ErrorProvider errorProvider1;
        private TabControl tabControl;
        private TabPage inputDataTab;
        private Button cancelButton;
        private Button applyButton;
        private Label investmentsPortionsLB;
        private Label projectsCountLB;
        private Label totalAmountLB;
        private TextBox investmentsPortionsTB;
        private TextBox projectsCountTB;
        private TextBox totalAmountTB;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonCreate;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonDelete;
        private DataGridView dataGVRevenue;
        private TabPage solutionTab;
        private DataGridView dataGVResult;
        private ToolStripButton toolStripButtonEdit;
        private ToolStripSeparator toolStripSeparator2;
        private Label tableLB;
        private Label matchLB;
        private Label sequenceLB;
        private Label resultLB;
        private Label sequenceInvestmentsLB;
        private TextBox sequenceInvestmentsTB;
    }
}