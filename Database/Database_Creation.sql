CREATE TABLE QuizzatorUser (
    UserID_PK int NOT NULL,
    Username varchar(100) NOT NULL,
    Password varchar(250)  NOT NULL,
    Email varchar(250) NOT NULL,
    PRIMARY KEY(UserID_PK)
)
CREATE TABLE QuizzatorTheme (
    ThemeID_PK int NOT NULL,
    ThemeName varchar (50) NOT NULL,
    ImagePath varchar(250) NOT NULL,  
    PRIMARY KEY(ThemeID_PK)
)
CREATE TABLE QuizzatorQuestion (
    QuestionID_PK int NOT NULL,
    ThemeID_FK int NOT NULL,
    QuestionText varchar(200) NOT NULL,
    BonneReponse_ID int NOT NULL,
    ImagePath VARCHAR(250) NOT NULL,
    PRIMARY KEY(QuestionID_PK),
    FOREIGN KEY (ThemeID_FK) REFERENCES QuizzatorTheme(ThemeID_PK)

)
CREATE TABLE QuizzatorReponse (
    ReponseID_PK int NOT NULL,
    QuestionID_FK int NOT NULL,
    ReponseTexte varchar(50) NOT NULL ,
    ReponseExplication VARCHAR(1000) NOT NULL ,
    ImagePath VARCHAR(250) NOT NULL,
    itTroll int NOT NULL,
    PRIMARY KEY(ReponseID_PK),
    FOREIGN KEY(QuestionID_FK) REFERENCES QuizzatorQuestion(QuestionID_PK)
)
CREATE TABLE QuizzatorLien (
    LienID_PK int NOT NULL, 
    ReponseID_FK int NOT NULL, 
    Lien VARCHAR (250) NOT NULL,
    PRIMARY KEY(LienID_PK),
    FOREIGN KEY(ReponseID_FK) REFERENCES QuizzatorReponse(ReponseID_PK)
)