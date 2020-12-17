using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// @version 0.1
    /// </author>
    public class PhotoPost
    {
        // username of the post's author
        public String Username { get; set; }

        // the name of the image file
        public String Filename { get; set; }
        
        // a one line image caption
        public String Caption { get; set; }   
        
        public DateTime Timestamp { get; }

        private int likes;
        
        private readonly  List<String> comments;

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author, String filename, String caption)
        {
            Username = author;
            this.Filename = filename;
            this.Caption = caption;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }


        ///<summary>
        /// Record one more 'Like' indication from a user.
        ///</summary>
        public void Like()
        {
            likes++;
        }


        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }


        ///<summary>
        /// Add a comment to this post.
        ///</summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>
        public void AddComment(String text)
        {
            comments.Add(text);
        }


        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Filename: [{Filename}]");
            Console.WriteLine($"    Caption: {Caption}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes: -  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    Comment(s): {comments.Count}  Click here to view.");
            }
        }


        /// <summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        /// The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>  
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time; 
            
            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}
