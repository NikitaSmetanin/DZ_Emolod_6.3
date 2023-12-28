using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DZ_Emolod_6._3
{
    public partial class Form1 : Form
    {
        List<Comment> comments = new List<Comment>();
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 8; i++)
            {
                comments.Add(new Comment(new User("user" + i), "Comment "+i));
            }

            createItems();
        }

        private void createItems()
        {
            for (int i = 0; i < comments.Count; i++)
            {
                createItem(comments[i], new Point(20, 20 + 100 * i));
            }
        }

        private GroupBox createItem(Comment comment, Point point) {             
            GroupBox item = new GroupBox();
            Label userName = new Label();
            TextBox commentText = new TextBox();
            CustomButton dislikeButton = new CustomButton();
            CustomButton likeButton = new CustomButton();           
            item.SuspendLayout();
            // 
            // item
            // 
            item.Controls.Add(dislikeButton);
            item.Controls.Add(likeButton);
            item.Controls.Add(commentText);
            item.Controls.Add(userName);
            item.Location = point;
            item.Name = "itemComment";
            item.Size = new Size(1004, 100);
            item.TabIndex = 0;
            item.TabStop = false;
            item.Text = comment.getUser().getId().ToString();
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(7, 42);
            userName.Name = "userName";
            userName.Size = new Size(53, 23);
            userName.TabIndex = 0;
            userName.Text = comment.getUser().getName();
            // 
            // commentText
            // 
            commentText.Location = new Point(84, 39);
            commentText.Name = "commentText";
            commentText.ReadOnly = true;
            commentText.Size = new Size(708, 30);
            commentText.TabIndex = 1;
            commentText.Text = comment.getText();
            // 
            // dislikeButton
            // 
            dislikeButton.Image = global::DZ_Emolod_6._3.Properties.Resources.dislike32;
            dislikeButton.Location = new Point(901, 36);
            dislikeButton.Name = "dislikeButton";
            dislikeButton.Size = new Size(75, 40);
            dislikeButton.TabIndex = 3;
            dislikeButton.Text = comment.getDislike().ToString();
            dislikeButton.TextAlign = ContentAlignment.MiddleRight;
            dislikeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dislikeButton.UseVisualStyleBackColor = true;
            dislikeButton.CommentId = comment.getId();
            dislikeButton.Click += (object? sender, EventArgs e) =>
            {
                GroupBox gb = ((CustomButton)sender).Parent as GroupBox;

                Comment comment = this.comments.Find(item => item.getId() == ((CustomButton)sender).CommentId);

                comment.setDislike(comment.getDislike() + 1);

                ((CustomButton)sender).Text = comment.getDislike().ToString();
            };
            // 
            // likeButton
            // 
            likeButton.Image = global::DZ_Emolod_6._3.Properties.Resources.like321;
            likeButton.Location = new Point(811, 36);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(75, 40);
            likeButton.TabIndex = 2;
            likeButton.Text = comment.getLike().ToString();
            likeButton.TextAlign = ContentAlignment.MiddleRight;
            likeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            likeButton.UseVisualStyleBackColor = true;
            likeButton.CommentId = comment.getId();
            likeButton.Click += (object? sender, EventArgs e) =>
            {
                GroupBox gb = ((CustomButton)sender).Parent as GroupBox;             

                Comment comment = this.comments.Find(item => item.getId() == ((CustomButton)sender).CommentId);

                comment.setLike(comment.getLike() + 1);

                ((CustomButton)sender).Text = comment.getLike().ToString();
            };

            this.Controls.Add(item);

            return item;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comments.Count; i++)
            {
                this.Controls.RemoveByKey("itemComment");
            }

            createItems();
        }
    }
}
