int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int count = 0;
int distance = 10000;
int time = 0;
while(distance > 10)
{
    if(friend == 1)
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    if(friend == 2)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");

