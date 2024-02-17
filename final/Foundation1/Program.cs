using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "The start of the end";
        video1._author = "Jon Smith";
        video1._lenght = 99;

        Video video2 = new Video();
        video2._title = "Glowing from inside out";
        video2._author = "Albert Frank II";
        video2._lenght = 463;

        Video video3 = new Video();
        video3._title = "The Earth before its creation";
        video3._author = "Rachel Rickty";
        video3._lenght = 255;
        
        // Comments for Video 1
        Comment comment1 = new Comment();
        comment1._name = "Richard";
        comment1._text = "This video was truly engaging, watch it!";

        Comment comment11 = new Comment();
        comment11._name = "Sarah";
        comment11._text = "There is no better video in the world - wow.";

        Comment comment12 = new Comment();
        comment12._name = "Zach";
        comment12._text = "Interesting but too short, what about the rest of the story?";

        // Comments for Video 2
        Comment comment2 = new Comment();
        comment2._name = "George";
        comment2._text = "I thought the end was kind of confusing.";

        Comment comment21 = new Comment();
        comment21._name = "William";
        comment21._text = "It seems that something was missing at the end.";

        Comment comment22 = new Comment();
        comment22._name = "Jacob";
        comment22._text = "Too slow most of the time, you should watched at 2x speed.";

        // Comments for Video 3
        Comment comment3 = new Comment();
        comment3._name = "Frank";
        comment3._text = "Clearly the producer was bored, the video is boring too.";

        Comment comment31 = new Comment();
        comment31._name = "Susan";
        comment31._text = "This video does not make much sense, don't recommend.";

        Comment comment32 = new Comment();
        comment32._name = "Melany";
        comment32._text = "I would not waste your time with this one.";

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        video1.AddComment(comment1);
        video1.AddComment(comment11);
        video1.AddComment(comment12);

        video2.AddComment(comment2);
        video2.AddComment(comment21);
        video2.AddComment(comment22);

        video3.AddComment(comment3);
        video3.AddComment(comment31);
        video3.AddComment(comment32);

        foreach (Video video in _videos)
        {
            Console.WriteLine($"\nVideo Title: {video._title}");
            Console.WriteLine($"Video Author {video._author}");
            Console.WriteLine($"Video lenght: {video._lenght} seconds");
            Console.WriteLine($"Number of comments: {video.TotalComments()}");
            Console.WriteLine($"Comments: ");

            foreach (Comment comm in video._comments)
            {
                comm.Display();
            }

            Console.WriteLine("_______________________________________________________");
        }

    }
}