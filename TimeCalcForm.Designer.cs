namespace TimeCalc;

partial class TimeCalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeCalcForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpCalc = new System.Windows.Forms.TabPage();
            this.timeCalcControl = new TimeCalc.TimeCalcControl();
            this.tpTimer = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.tpCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpCalc);
            this.tcMain.Controls.Add(this.tpTimer);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(5, 5);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(320, 182);
            this.tcMain.TabIndex = 0;
            // 
            // tpCalc
            // 
            this.tpCalc.Controls.Add(this.timeCalcControl);
            this.tpCalc.Location = new System.Drawing.Point(4, 31);
            this.tpCalc.Name = "tpCalc";
            this.tpCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalc.Size = new System.Drawing.Size(312, 147);
            this.tpCalc.TabIndex = 0;
            this.tpCalc.Text = "Calc";
            this.tpCalc.UseVisualStyleBackColor = true;
            // 
            // timeCalcControl
            // 
            this.timeCalcControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeCalcControl.Init = new System.DateTime(2022, 12, 29, 19, 4, 12, 123);
            this.timeCalcControl.Location = new System.Drawing.Point(3, 3);
            this.timeCalcControl.Name = "timeCalcControl";
            this.timeCalcControl.Result = new System.DateTime(2022, 12, 29, 19, 4, 12, 123);
            this.timeCalcControl.Size = new System.Drawing.Size(306, 141);
            this.timeCalcControl.TabIndex = 0;
            // 
            // tpTimer
            // 
            this.tpTimer.Location = new System.Drawing.Point(4, 31);
            this.tpTimer.Name = "tpTimer";
            this.tpTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tpTimer.Size = new System.Drawing.Size(312, 147);
            this.tpTimer.TabIndex = 1;
            this.tpTimer.Text = "Timer";
            this.tpTimer.UseVisualStyleBackColor = true;
            // 
            // TimeCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(330, 192);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("JetBrainsMonoExtraBold NF", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeCalcForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "TimeCalc";
            this.tcMain.ResumeLayout(false);
            this.tpCalc.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private TabControl tcMain;
    private TabPage tpCalc;
    private TabPage tpTimer;
    private TimeCalcControl timeCalcControl;
}
