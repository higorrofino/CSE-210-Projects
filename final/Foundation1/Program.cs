using System;

class Program
{
    static void Main(string[] args)
    {
        //first video
        Comment c1 = new Comment();
        c1._name = "Harry";
        c1._textComment = "The video has low quality.";
        
        Comment c11 = new Comment();
        c11._name = "John";
        c11._textComment = "The length is great to impact people who have no time.";
        
        Comment c111 = new Comment();
        c111._name = "Alberta";
        c111._textComment = "The subtitles is faster than the audio.";

        Video v1 = new Video();
        v1._title = "Top 5 artists in 2023";
        v1._author = "Zildo";
        v1._length = 45;
        v1._comments.Add(c1);
        v1._comments.Add(c11);
        v1._comments.Add(c111);
        v1.Display();
        
        //second video
        Comment c2 = new Comment();
        c2._name = "Henry";
        c2._textComment = "Great job, the entire video is awesome.";
        
        Comment c22 = new Comment();
        c22._name = "Amelia";
        c22._textComment = "The video is really great, but will be better if was faster.";
        
        Comment c222 = new Comment();
        c222._name = "Kane";
        c222._textComment = "Selected as top 10 best videos.";

        Video v2 = new Video();
        v2._title = "Rock-Lee vs Gaara";
        v2._author = "Zan";
        v2._length = 500;
        v2._comments.Add(c2);
        v2._comments.Add(c22);
        v2._comments.Add(c222);
        v2.Display();
        
        //third video
        Comment c3 = new Comment();
        c3._name = "Thomas";
        c3._textComment = "Perfect topic for now.";
        
        Comment c33 = new Comment();
        c33._name = "George";
        c33._textComment = "Agree, but specific things I doubt.";
        
        Comment c333 = new Comment();
        c333._name = "Jane";
        c333._textComment = "Congrats to share you politic opinion.";

        Video v3 = new Video();
        v3._title = "How to know who is better to vote";
        v3._author = "Greg";
        v3._length = 800;
        v3._comments.Add(c3);
        v3._comments.Add(c33);
        v3._comments.Add(c333);
        v3.Display();
    }
}