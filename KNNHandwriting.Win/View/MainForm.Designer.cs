namespace KNNHandwriting.Win.View
{
  partial class MainForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox15 = new System.Windows.Forms.GroupBox();
      this.dgvAnalysisSource = new System.Windows.Forms.DataGridView();
      this.colTrainingImage = new System.Windows.Forms.DataGridViewImageColumn();
      this.colTrainingLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrainingFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.dgvAnalysisTesting = new System.Windows.Forms.DataGridView();
      this.colTestingImage = new System.Windows.Forms.DataGridViewImageColumn();
      this.colTestingExpected = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTestingOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTestingFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.lblClassifiedDigit = new System.Windows.Forms.Label();
      this.btnRecognize = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnLoad = new System.Windows.Forms.Button();
      this.btnClassify = new System.Windows.Forms.Button();
      this.numK = new System.Windows.Forms.NumericUpDown();
      this.lblK = new System.Windows.Forms.Label();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.canvas = new KNNHandwriting.Win.View.Canvas();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.groupBox15.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisSource)).BeginInit();
      this.groupBox7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisTesting)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numK)).BeginInit();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.71675F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 582F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 617);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.59292F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.40708F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
      this.tableLayoutPanel2.Controls.Add(this.groupBox15, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.groupBox1, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 10);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(874, 576);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // groupBox15
      // 
      this.groupBox15.Controls.Add(this.dgvAnalysisSource);
      this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox15.Location = new System.Drawing.Point(3, 3);
      this.groupBox15.Name = "groupBox15";
      this.groupBox15.Size = new System.Drawing.Size(224, 570);
      this.groupBox15.TabIndex = 9;
      this.groupBox15.TabStop = false;
      this.groupBox15.Text = "Training";
      // 
      // dgvAnalysisSource
      // 
      this.dgvAnalysisSource.AllowUserToAddRows = false;
      this.dgvAnalysisSource.AllowUserToDeleteRows = false;
      this.dgvAnalysisSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
      this.dgvAnalysisSource.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dgvAnalysisSource.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dgvAnalysisSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvAnalysisSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvAnalysisSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvAnalysisSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrainingImage,
            this.colTrainingLabel,
            this.colTrainingFeatures});
      this.dgvAnalysisSource.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvAnalysisSource.Location = new System.Drawing.Point(3, 16);
      this.dgvAnalysisSource.Name = "dgvAnalysisSource";
      this.dgvAnalysisSource.ReadOnly = true;
      this.dgvAnalysisSource.RowHeadersVisible = false;
      this.dgvAnalysisSource.Size = new System.Drawing.Size(218, 551);
      this.dgvAnalysisSource.TabIndex = 6;
      // 
      // colTrainingImage
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
      dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
      this.colTrainingImage.DefaultCellStyle = dataGridViewCellStyle2;
      this.colTrainingImage.HeaderText = "Character";
      this.colTrainingImage.Name = "colTrainingImage";
      this.colTrainingImage.ReadOnly = true;
      this.colTrainingImage.Width = 59;
      // 
      // colTrainingLabel
      // 
      this.colTrainingLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.colTrainingLabel.DefaultCellStyle = dataGridViewCellStyle3;
      this.colTrainingLabel.HeaderText = "Label";
      this.colTrainingLabel.Name = "colTrainingLabel";
      this.colTrainingLabel.ReadOnly = true;
      // 
      // colTrainingFeatures
      // 
      this.colTrainingFeatures.HeaderText = "Features (array)";
      this.colTrainingFeatures.Name = "colTrainingFeatures";
      this.colTrainingFeatures.ReadOnly = true;
      this.colTrainingFeatures.Visible = false;
      this.colTrainingFeatures.Width = 105;
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.dgvAnalysisTesting);
      this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox7.Location = new System.Drawing.Point(233, 3);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(316, 570);
      this.groupBox7.TabIndex = 14;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Testing";
      // 
      // dgvAnalysisTesting
      // 
      this.dgvAnalysisTesting.AllowUserToAddRows = false;
      this.dgvAnalysisTesting.AllowUserToDeleteRows = false;
      this.dgvAnalysisTesting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvAnalysisTesting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dgvAnalysisTesting.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dgvAnalysisTesting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvAnalysisTesting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dgvAnalysisTesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvAnalysisTesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTestingImage,
            this.colTestingExpected,
            this.colTestingOutput,
            this.colTestingFeatures});
      this.dgvAnalysisTesting.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvAnalysisTesting.Location = new System.Drawing.Point(3, 16);
      this.dgvAnalysisTesting.Name = "dgvAnalysisTesting";
      this.dgvAnalysisTesting.ReadOnly = true;
      this.dgvAnalysisTesting.RowHeadersVisible = false;
      this.dgvAnalysisTesting.Size = new System.Drawing.Size(310, 551);
      this.dgvAnalysisTesting.TabIndex = 6;
      // 
      // colTestingImage
      // 
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
      dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
      this.colTestingImage.DefaultCellStyle = dataGridViewCellStyle5;
      this.colTestingImage.HeaderText = "Character";
      this.colTestingImage.Name = "colTestingImage";
      this.colTestingImage.ReadOnly = true;
      // 
      // colTestingExpected
      // 
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.colTestingExpected.DefaultCellStyle = dataGridViewCellStyle6;
      this.colTestingExpected.HeaderText = "Label";
      this.colTestingExpected.Name = "colTestingExpected";
      this.colTestingExpected.ReadOnly = true;
      // 
      // colTestingOutput
      // 
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.colTestingOutput.DefaultCellStyle = dataGridViewCellStyle7;
      this.colTestingOutput.HeaderText = "Classification";
      this.colTestingOutput.Name = "colTestingOutput";
      this.colTestingOutput.ReadOnly = true;
      // 
      // colTestingFeatures
      // 
      this.colTestingFeatures.HeaderText = "Features (array)";
      this.colTestingFeatures.Name = "colTestingFeatures";
      this.colTestingFeatures.ReadOnly = true;
      this.colTestingFeatures.Visible = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.btnLoad);
      this.groupBox1.Controls.Add(this.btnClassify);
      this.groupBox1.Controls.Add(this.numK);
      this.groupBox1.Controls.Add(this.lblK);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(555, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(316, 570);
      this.groupBox1.TabIndex = 15;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Setting";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnClear);
      this.groupBox2.Controls.Add(this.canvas);
      this.groupBox2.Controls.Add(this.lblClassifiedDigit);
      this.groupBox2.Controls.Add(this.btnRecognize);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Location = new System.Drawing.Point(6, 300);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(294, 264);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Usage";
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(91, 152);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(58, 23);
      this.btnClear.TabIndex = 8;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // lblClassifiedDigit
      // 
      this.lblClassifiedDigit.AutoSize = true;
      this.lblClassifiedDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblClassifiedDigit.Location = new System.Drawing.Point(193, 75);
      this.lblClassifiedDigit.Name = "lblClassifiedDigit";
      this.lblClassifiedDigit.Size = new System.Drawing.Size(74, 31);
      this.lblClassifiedDigit.TabIndex = 7;
      this.lblClassifiedDigit.Text = "Digit";
      // 
      // btnRecognize
      // 
      this.btnRecognize.Location = new System.Drawing.Point(10, 152);
      this.btnRecognize.Name = "btnRecognize";
      this.btnRecognize.Size = new System.Drawing.Size(75, 23);
      this.btnRecognize.TabIndex = 5;
      this.btnRecognize.Text = "Recognize";
      this.btnRecognize.UseVisualStyleBackColor = true;
      this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(181, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(78, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Classified Digit:";
      // 
      // btnLoad
      // 
      this.btnLoad.Location = new System.Drawing.Point(43, 56);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(75, 23);
      this.btnLoad.TabIndex = 3;
      this.btnLoad.Text = "Load Data";
      this.btnLoad.UseVisualStyleBackColor = true;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // btnClassify
      // 
      this.btnClassify.Location = new System.Drawing.Point(43, 142);
      this.btnClassify.Name = "btnClassify";
      this.btnClassify.Size = new System.Drawing.Size(75, 23);
      this.btnClassify.TabIndex = 2;
      this.btnClassify.Text = "Classify";
      this.btnClassify.UseVisualStyleBackColor = true;
      this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
      // 
      // numK
      // 
      this.numK.Location = new System.Drawing.Point(43, 101);
      this.numK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numK.Name = "numK";
      this.numK.Size = new System.Drawing.Size(75, 20);
      this.numK.TabIndex = 1;
      this.numK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lblK
      // 
      this.lblK.AutoSize = true;
      this.lblK.Location = new System.Drawing.Point(13, 103);
      this.lblK.Name = "lblK";
      this.lblK.Size = new System.Drawing.Size(17, 13);
      this.lblK.TabIndex = 0;
      this.lblK.Text = "K:";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
      this.statusStrip1.Location = new System.Drawing.Point(0, 595);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(880, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tssStatus
      // 
      this.tssStatus.Name = "tssStatus";
      this.tssStatus.Size = new System.Drawing.Size(0, 17);
      // 
      // canvas
      // 
      this.canvas.BackColor = System.Drawing.SystemColors.Window;
      this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.canvas.Location = new System.Drawing.Point(10, 19);
      this.canvas.Name = "canvas";
      this.canvas.PenSize = 4;
      this.canvas.Size = new System.Drawing.Size(139, 127);
      this.canvas.TabIndex = 4;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(880, 617);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.groupBox15.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisSource)).EndInit();
      this.groupBox7.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisTesting)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numK)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.GroupBox groupBox15;
    private System.Windows.Forms.DataGridView dgvAnalysisSource;
    private System.Windows.Forms.DataGridViewImageColumn colTrainingImage;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingLabel;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingFeatures;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.DataGridView dgvAnalysisTesting;
    private System.Windows.Forms.DataGridViewImageColumn colTestingImage;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTestingExpected;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTestingOutput;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTestingFeatures;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnClassify;
    private System.Windows.Forms.NumericUpDown numK;
    private System.Windows.Forms.Label lblK;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tssStatus;
    private System.Windows.Forms.Button btnLoad;
    private Canvas canvas;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label lblClassifiedDigit;
    private System.Windows.Forms.Button btnRecognize;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnClear;

  }
}