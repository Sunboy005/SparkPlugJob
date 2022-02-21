# SparkPlugJob
Solution to This coding Challenge- [Approovia Challenge](https://github.com/Approovia-Limited/CodingChallenge-02-22)

## *My Thought Process*.
- The model of the messageDTO sent from the HTML contains the all needed properties.
- The WebApi recieved the payload from form which is passed through route.
- I mapped the message comming as a DTO to the message model. 
- Then I used `_formDomain` property from the DTO to serves as the Database name as domainName is Unique. 
- Using mongodbClient.Get(_formDomain), I was able to check and create a new database;
- Also I used `_formName` property from the DTO to serve as the Collections' name.
- Using `database.GetCollection(_formName)`, I was able to check if it exist.
- If no, It create a new one with `database.CreateCollectionAsync(model._formName)`.
- Then I insert the document of the mapped message into the collection using `collection.InsertOneAsync(message)`.
- I used try and catch keywords to check if the insert method's work because it returns void so no means of keeping track of the success,
- If it succeed it returns success boolean type with value true.
- Else it will return success boolean value with false as it will be return as a catch error
-For the HTML **(customerForm.html)**; I Added The Following codes at Line 117
 -*`var endpoint = `https://localhost:44321/customerform/send-message/${companyToSend}`; //change this to a valid endpoint;`*
