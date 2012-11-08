Homepage
========

This is my homepage made in ASP.NET MVC 3

How to configure automatic authentication for pulls on Windows: 

1. Create repository on GitHub , eg "Repo"
2. Clone repository in local machine using git bash ("git clone git://github.com/Username/Repo.git") 
3. Generate SSH keys with PuttyGen, enter key comment as the name of key , eg your email
4. Copy body of public key from putty (remember of ssh-rsa headding!)
5. Paste in in github.com ("https://github.com/settings/ssh") - by convention , Comment will become the key Title 
6. Save private key on your local machine
7. Click on repository folder git settings (Settings-> Git -> Remote), click on "origin" and enter path to Putty Private Key
8. Now if you don't want to enter user/pass for github.com everytime you push the commit, change repository address from https to ssh ("git remote set-url origin git@github.com:Username/Repo.git")

That's it!