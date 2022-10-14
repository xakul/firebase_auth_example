// See https://aka.ms/new-console-template for more information

using Firebase.Auth;

const string API_KEY = "AIzaSyC__fXAe7B65SJcWERUtKXBISZ8xF4jgq0";

FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(API_KEY));

//FirebaseAuthLink firebaseAuthLink = await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync("deneme@deneme.com", "deneme123", "deneme", false);

FirebaseAuthLink firebaseAuthLink = await firebaseAuthProvider.SignInWithEmailAndPasswordAsync("deneme@deneme.com", "deneme123");


Console.WriteLine(firebaseAuthLink);

Console.WriteLine(firebaseAuthLink.FirebaseToken);


Console.WriteLine("Hello, World!");
Console.WriteLine(API_KEY);