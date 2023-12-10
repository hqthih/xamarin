using Firebase.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FirebaseDatabaseHelper
{
    FirebaseClient firebaseClient;

    public FirebaseDatabaseHelper()
    {
        // Initialize Firebase database
        firebaseClient = new FirebaseClient("YOUR_FIREBASE_DATABASE_URL");
    }

    public async Task<List<QuestionModel>> GetQuestions()
    {
        var questions = await firebaseClient
            .Child("questions")
            .OnceAsync<QuestionModel>();

        return questions.Select(item => new QuestionModel
        {
            Id = item.Object.Id,
            Text = item.Object.Text,
            Answer = item.Object.Answer
        }).ToList();
    }
}
