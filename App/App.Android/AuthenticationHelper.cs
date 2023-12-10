using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Firebase;
using Firebase.Auth;
using System.Threading.Tasks;

namespace App
{
    public class AuthenticationHelper
    {
        FirebaseAuth firebaseAuth;

        public AuthenticationHelper()
        {
            firebaseAuth = FirebaseHelper.GetFirebaseAuth();
        }

        public async Task<string> SignInWithEmailAndPassword(string email, string password)
        {
            try
            {
                var result = await firebaseAuth.SignInWithEmailAndPasswordAsync(email, password);
                return result.User.Uid;
            }
            catch (Exception ex)
            {
                // Handle authentication error
                return null;
            }
        }
    }


}
