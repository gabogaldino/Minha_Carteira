# Minha Carteira

## 1 Project description:
A simple personal finance manager system made in .NET. Its differential is in its simplicity: designed to be secure, fast, easy to use, and effective in functionality. It is proposed to be built with adherence to the market and as a demonstration of the value of Microsoft technologies for desktop applications.

Demonstration video of application use: https://www.youtube.com/watch?v=FsBJ4yT1Wkk

![image](https://user-images.githubusercontent.com/66391286/218500392-e8bfb685-5b6a-4a09-a1be-c742903902ce.png)

## 2 Target audience
Creation of a market research sent to communities and social networks, obtaining more than 22 responses.

Understanding the target audience through research:

- 40% of people do their financial organization via desktop (Excel/Website).
- 31% do not do it.
- Major difficulties: "an easy way to catalog and organize all expenses"; Interface that stimulates this, simple category separation
- 80% of participants reported that security is essential for this type of application; 50% for ease of use and 40% for simplicity.
- 50% feel the need for a desktop application for this type of function.

## 2.1 Persona
From the data collected by the research, considering the audience with greater adherence to the use of our application, we built the following persona:

"Fernanda Fraga". Fernanda is 30 years old, works as a Product Manager and is very critical when selecting an application. She likes minimalism and practicality in her daily life. "I prefer to organize my personal tasks on the computer."

Motivation: To have more of a habit of organizing personal finances. Support: She resorts to online spreadsheets when she needs them. Mistakes: Forgets to write down the expenses. Ends up saving with unindexed categories. Care: Uses antivirus and is always updated on virtual security needs.

## 3 Functional requirements:
With the information from the research, we built a Use Case Diagram to understand the functional requirements in practice:

![image](https://user-images.githubusercontent.com/66391286/218500645-e664399c-9f5e-4230-bd1d-5c388685db9d.png)

- The application must allow the creation of categories for expenses.
- The application must allow the launch of expenses with the following data (date, value, description, and category).
- The application must allow the visualization of the total expenses per month.
- The application must allow the visualization of the total expenses per category of the month.
- The application must allow editing of registered categories.
- The application must allow editing or deletion of launched expenses.

## 4 Non-functional requirements:
In addition to the processes that involve the product's functionality, we also sought to consider security as an important process early on in construction. To think about security requirements, we continued with the threat modeling exercise with a focus on the core component of our service.

![image](https://user-images.githubusercontent.com/66391286/218504255-4c535b89-1bda-4f44-9720-e656178e874a.png)

Understanding that, in this initial case, we should contain potential threats to the database by building parameterized queries. Defining controls from threats:

![image](https://user-images.githubusercontent.com/66391286/218501789-5c4aa702-ce2b-4785-82b7-679d68b0dade.png)

Thus, building the following security requirements as initial examples, discussed in pairs and based on OWASP ASVS:

- Only people who have been authenticated by an access control and authentication component can view information since confidentiality allows this type of access only to authorized personnel
- Ensure that all data inputs are treated securely to prevent SQL injection attacks
- Continuous monitoring of application security to quickly detect and correct any vulnerabilities or issues. 
- In pairs, we decided on the following non-functional requirements to enhance the technical and process quality of the product creation:

- The system must be implemented in the .NET framework
- The system must follow the DevOps methodology of agility
- The system should communicate with the SQLite database
- The system must use an MVC layered architecture pattern.

These requirements allow us to keep the code cleaner and more organized, as well as improve the quality of the final product.

![image](https://user-images.githubusercontent.com/66391286/218506353-d9d1eddd-318d-49ed-bcbe-8c8978ef8cfb.png)

To support this process, we also use [Conviso Platform's Secure by Design](bit.ly/3ulSiVk), which makes it easy for us to perform threat modeling with attack patterns and automated requirements.

## 5 Code security analysis

As part of our development process, we use an automated SAST (Static Application Security Testing), from Conviso's Secure Pipeline, in Azure DevOps for each approved code before deploying it to our production environment. This helps us identify and fix security vulnerabilities in our code before it is deployed.

![image](https://user-images.githubusercontent.com/66391286/218505258-364d2c29-19e2-4a64-a235-da99dd9dee8d.png)


## 6 User Interface
To help us build more modern screens, we use Figma together with a Design System to standardize the components of the product screens. Remembering that these screens were not implemented due to time.
Here are screenshots created using Figma:
![image](https://user-images.githubusercontent.com/66391286/218503603-76fc67e2-d293-4cc5-a309-987c6f725b59.png)
![image](https://user-images.githubusercontent.com/66391286/218503682-ffc85582-8d76-436e-8743-7d28f217685b.png)
![image](https://user-images.githubusercontent.com/66391286/218503789-138c4686-c492-4119-a98a-74a0b98ebb9c.png)


## 7 How to run the project:

Install .NET Framework on your machine
Clone the project repository
Run the command 'dotnet run' in the terminal, in the project directory
Open the application in the browser at the address 'https://localhost:5001'

## 8 How to contribute:

Fork the project repository
Create a branch with your new feature: git checkout -b my-feature
Commit your changes: git commit -m "feature: My new feature"
Push your branch: git push origin my-feature
Open a pull request in the project repository

## 9 License:
This project is licensed under the Apache License 2.0. See the [LICENSE](/LICENSE) file for details.
