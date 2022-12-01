//Reed Goodwin
//12/1/2022
//TAController quiz



using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_TACONTRollerquiz.Controllers;

[ApiController]
[Route("[controller]")]
public class BestTAsController : ControllerBase
{
    //This takes 2 numbers in the route as inputs and converts
    //them and adds them together and returns the value
    [HttpGet]
    [Route("AddTwoNumbers/{number1}/{number2}")]
    public int multiplies(string number1, string number2){
    int convertNum1 = Convert.ToInt32(number1);
    int convertNum2 = Convert.ToInt32(number2);
    return convertNum1 * convertNum2;

}



[HttpGet]
[Route("ReverseIt/{word}")]
public string rev(string word){


   //This takes the string and uses the .Reverse to reverse it then put it in a string
            var resultstring = new string(word.ToCharArray().Reverse().ToArray());
return $"\n{word} reversed is {resultstring}!!";
}

//This takes 1 input from the route and replies with "hello +name"
[HttpGet]
    [Route("SayHello/{name}")]
    public string dinnerfood(string name){
        
return $"whats up {name}!";
}
   

//I coudlnt get it to print on postman, its linked but it just drops a 1
//Can you elaborate on why that might be? I feel like its something simple I 
//Should know that im just overlooking
//Im hoping im just doing the link wrong

}

