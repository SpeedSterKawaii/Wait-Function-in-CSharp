public async void Wait(int time)
{
    await Task.Delay(time + 000); //must be something like 500 in order to do 5 seconds.
    //if i do 100 it will do 1 second.
}
