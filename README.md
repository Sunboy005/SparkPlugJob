# SparkPlugJob
Solution to This coding Challenge-  https://github.com/Approovia-Limited/CodingChallenge-02-22

## *My Thought Process*.
- The companys' name should be passed by route to the WebApi when the request is Made, so I modified the  html webform
- The WebApi Recieved the payload from form and as I stated earlier, companys' name is passed through route.
- The companys' name that is passed serves as the Database nane.
- In the Services, I checked if the database exist before checking for collection.
- If it does not have the database, the database will be created and also the collections.
- if it deoes have the check will be skipped and the document will be saved.
