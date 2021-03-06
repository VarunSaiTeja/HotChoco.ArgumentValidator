# Steps for configuring validator


### Step 1
Go to StartUp.cs file and inside ConfigureServices make the following changes.

### Step 2
Keep this code to validate all inputs of GraphQL Query/Mutation.
```
ValidatorSettings.ValdiateAllInputs = true;
```

### Step 3
Add argument valdiator to services by referring below code
```
services
  .AddGraphQLServer()
  .AddArgumentValidator();
```

### Additional Configuration
If you don't want to valdiate all inputs then you can skip step 2 and follow the optional step i.e

Just add `Validatable` attribute to the class u defined for input.

Ex:
```
    [Validatable]
    public class AddUserInput
    {
        [Required, MinLength(4, ErrorMessage = "Username must be atleast 4 characters.")]
        public string UserName { get; set; }

        [Required, RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email Id format is invalid")]
        public string Email { get; set; }

        [Required, RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password must be atleast 8 characters, at least one uppercase letter, one lowercase letter, one number and one special character.")]
        public string Password { get; set; }
    }
```


When user miss
