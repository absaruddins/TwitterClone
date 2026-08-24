using Twitter.Test;
using TwitterClone.Domain.Entities;


//Console.WriteLine("Task 1 completed.");

//var likeNotification = new LikeNotification(Guid.NewGuid());
//Console.WriteLine(likeNotification.GetMessage());

//var commentNotification = new CommentNotification(Guid.NewGuid());
//Console.WriteLine(commentNotification.GetMessage());

//var friendRequestNotification = new FriendRequestNotification(Guid.NewGuid());
//Console.WriteLine(friendRequestNotification.GetMessage());

//var mentionedNotification = new MentionNotification(Guid.NewGuid());

//Console.WriteLine(mentionedNotification.GetMessage());

////Task 2: emonn kichu dorkar jano mention class obbsi Getmessage method ovrride kore



//opor er gola loop use kore kora jai,upcasting er maddome
//eta ke abar run time polymorphism bole
var notifications = new List<Notification>() //upcasting ,array er moto
{
    new LikeNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),
    new FriendRequestNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new SystemNotification()
};


foreach(var notification in notifications)
{
    Console.WriteLine(notification.GetMessage());
}





