namespace WinFormsApp1;

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
        label1 = new Label();
        label2 = new Label();
        textBoxUser = new TextBox();
        textBoxPassword = new TextBox();
        label3 = new Label();
        textBoxSession = new TextBox();
        button1 = new Button();
        buttonForgot = new Button();
        button3 = new Button();
        labelTime = new Label();
        label4 = new Label();
        label5 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(135, 82);
        label1.Name = "label1";
        label1.Size = new Size(32, 15);
        label1.TabIndex = 0;
        label1.Text = "user:";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(135, 109);
        label2.Name = "label2";
        label2.Size = new Size(60, 15);
        label2.TabIndex = 1;
        label2.Text = "password:";
        // 
        // textBoxUser
        // 
        textBoxUser.Location = new Point(234, 79);
        textBoxUser.Name = "textBoxUser";
        textBoxUser.Size = new Size(100, 23);
        textBoxUser.TabIndex = 2;
        // 
        // textBoxPassword
        // 
        textBoxPassword.Location = new Point(234, 106);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new Size(100, 23);
        textBoxPassword.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(135, 139);
        label3.Name = "label3";
        label3.Size = new Size(48, 15);
        label3.TabIndex = 4;
        label3.Text = "session:";
        // 
        // textBoxSession
        // 
        textBoxSession.Location = new Point(234, 131);
        textBoxSession.Name = "textBoxSession";
        textBoxSession.Size = new Size(100, 23);
        textBoxSession.TabIndex = 5;
        // 
        // button1
        // 
        button1.Location = new Point(216, 212);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 6;
        button1.Text = "Log in";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // buttonForgot
        // 
        buttonForgot.Location = new Point(413, 279);
        buttonForgot.Name = "buttonForgot";
        buttonForgot.Size = new Size(89, 23);
        buttonForgot.TabIndex = 7;
        buttonForgot.Text = "Forgot details";
        buttonForgot.UseVisualStyleBackColor = true;
        buttonForgot.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(437, 12);
        button3.Name = "button3";
        button3.Size = new Size(65, 23);
        button3.TabIndex = 8;
        button3.Text = "THEME";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // labelTime
        // 
        labelTime.AutoSize = true;
        labelTime.Location = new Point(234, 12);
        labelTime.Name = "labelTime";
        labelTime.Size = new Size(30, 15);
        labelTime.TabIndex = 9;
        labelTime.Text = "date";
        labelTime.Click += labelTime_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 12);
        label4.Name = "label4";
        label4.Size = new Size(93, 15);
        label4.TabIndex = 10;
        label4.Text = "last user logged:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(44, 48);
        label5.Name = "label5";
        label5.Size = new Size(38, 15);
        label5.TabIndex = 11;
        label5.Text = "label5";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(514, 314);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(labelTime);
        Controls.Add(button3);
        Controls.Add(buttonForgot);
        Controls.Add(button1);
        Controls.Add(textBoxSession);
        Controls.Add(label3);
        Controls.Add(textBoxPassword);
        Controls.Add(textBoxUser);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBoxUser;
    private TextBox textBoxPassword;
    private Label label3;
    private TextBox textBoxSession;
    private Button button1;
    private Button buttonForgot;
    private Button button3;
    private Label labelTime;
    private Label label4;
    private Label label5;
}