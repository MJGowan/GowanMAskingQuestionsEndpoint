/*Madeline Gowan
10-25-2022
Asking Questions - Endpoint
This program will ask questions. Specifically, mine asks for your favorite animal and your favorite food. Now compatible with postman

Peer review:// Noah - easy to read code looks awsome code matches subject                                                                                                                                                                                                 `        ``````

*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{

//cheat sheet: https://localhost:xxxx/Questions/Favorite/animal/food

    [HttpGet]
    [Route("Favorite/{animal}/{food}")]
    public string Favorite(string animal, string food)
    {
        return $"Hello! I have a question for you. What's your favorite animal? \n {animal}. \n That one's cool! So what's your favorite food? \n {food}. \n Nice. My favorite snack is french fries.";
    }
}
