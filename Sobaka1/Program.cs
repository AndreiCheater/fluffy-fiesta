int count = 0, firstFriendSpeed = 1, 
    secondFriendSpeed = 2, dogSpeed = 5, friend = 2;
double time, distance = 15;
while(distance > 10)
{
    if(friend == 1)
    {
        time = distance/ (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/ (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)* time;
    count++;
}
Console.WriteLine(count);
