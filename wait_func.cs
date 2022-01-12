public async void Wait(int time)
{
    await Task.Delay(time + 000);
    //if i do 100 it will do 1 second.
    
    MessageBox.Show("Hi I loaded after " + time + " second(s)!");
}

Wait(500); //wait 5 seconds :) enjoy
