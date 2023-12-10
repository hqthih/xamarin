using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Firebase;
using Firebase.Auth;

namespace App
{
    public class FirebaseHelper
    {
        // Initialize Firebase in your App.xaml.cs or equivalent
        public static void InitializeFirebase()
        {
            var options = new FirebaseOptions.Builder()
                .SetApplicationId("YOUR_APP_ID")
                .SetApiKey("YOUR_API_KEY")
                .Build();

            FirebaseApp.InitializeApp(Application.Context, options);
        }

        // Get Firebase authentication instance
        public static FirebaseAuth GetFirebaseAuth()
        {
            return FirebaseAuth.Instance;
        }
    }

}
