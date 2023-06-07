CREATE DATABASE weather_station_inf
DROP DATABASE weather_station_inf
use weather_station_inf

CREATE TABLE WeatherStation
( MeasurementID int NOT NULL IDENTITY
          CONSTRAINT PK_Weather_Station PRIMARY KEY,
  StationID int NULL,
  CityStation varchar(25) NULL,
  MeasurementDate date NULL,
  DayLength varchar(15) NULL
  CHECK(LEFT(DayLength, 2) >= 0 AND LEFT(DayLength, 2) <= 24 AND SUBSTRING(DayLength, 4, 2) >= 0 AND SUBSTRING(DayLength, 4, 2) <= 59
  AND SUBSTRING(DayLength, 7, 2) >= 0 AND SUBSTRING(DayLength, 7, 2) <= 59)
)

INSERT INTO WeatherStation (StationID, CityStation, MeasurementDate, DayLength)
VALUES (1,'София','2021-10-24','10:41:26'),
	   (1,'София','2021-06-15','15:13:03'),
	   (1,'София','2022-04-18','13:12:52'),
	   (2,'Видин','2021-06-05','15:10:08'),
	   (3,'Велико Търново','2022-03-28','12:23:19'),
	   (3,'Велико Търново','2022-09-17','12:11:02'),
	   (4,'Русе','2021-11-11','09:56:12'),
	   (5,'Добрич','2022-01-21','09:31:55'),
	   (6,'Варна','2022-05-14','14:35:01'),
	   (6,'Варна','2021-08-08','14:16:34'),
	   (7,'Бургас','2021-08-31','13:06:47'),
	   (8,'Сливен','2022-12-20','09:02:16'),
	   (9,'Кърджали','2022-09-17','12:11:00'),
	   (10,'Пловдив','2022-04-18','13:12:53'),
	   (10,'Пловдив','2022-11-26','09:21:17'),
	   (11,'Сандански','2022-07-03','15:17:10'),
	   (12,'Кюстендил','2021-02-13','10:24:32')

CREATE TABLE Clouds
( PercentID int NOT NULL IDENTITY
          CONSTRAINT PK_Clouds PRIMARY KEY,
  PercentSkyCover varchar(10) NULL,
  Cloudiness varchar(25) NULL
)

INSERT INTO Clouds (PercentSkyCover, Cloudiness)
VALUES ('0-10%','Ясно'),
       ('10-30%','Предимно слънчево'),
       ('30-60%','Частично облачно'),
	   ('60-70%','Частично сънчево'), 
       ('70-90%','Предимно облачно'), 
	   ('90-100%','Облачно')

CREATE TABLE MeasurementDetailsDay
( DateID int NOT NULL IDENTITY
          CONSTRAINT PK_Measurement_Details_Day PRIMARY KEY,
  PercentID int NOT NULL
          CONSTRAINT FK_Details_Day_Cloudiness
          FOREIGN KEY REFERENCES Clouds(PercentID),
  WindSpeedMS decimal(3,1) NULL,
  CloudCoverPercentage int NULL
  CHECK(CloudCoverPercentage >= 0 AND CloudCoverPercentage <= 100),
  Rain varchar(10) NULL
)

INSERT INTO MeasurementDetailsDay (PercentID, WindSpeedMS, CloudCoverPercentage, Rain)
VALUES (4,5.5,68,'7.0 mm'),
	   (2,2.3,25,'2.3 mm'),
	   (1,4.5,6,'0.0 mm'),
	   (2,4.2,14,'0.6 mm'),
	   (1,1.2,10,'1.5 mm'),
	   (5,0.6,87,'6.3 mm'),
	   (6,5.1,91,'8.5 mm'),
	   (4,10.9,64,'3.6 mm'),
	   (2,8.3,12,'4.9 mm'),
	   (1,1.6,5,'0.8 mm'),
	   (2,0.1,19,'0.0 mm'),
	   (2,7.9,23,'5.4 mm'),
	   (3,0.6,41,'6.3 mm'),
	   (5,5.4,9,'0.0 mm'),
	   (1,3.8,1,'1.4 mm'),
	   (3,1.4,37,'0.0 mm'),
	   (2,3.9,18,'10.98 mm')

CREATE TABLE MeasurementDetailsHour
( DateID int NOT NULL
          CONSTRAINT FK_Details_Hour_Date
          FOREIGN KEY REFERENCES MeasurementDetailsDay(DateID),
  MeasurementID int NOT NULL
          CONSTRAINT FK_Details_Hour_Measurement
          FOREIGN KEY REFERENCES WeatherStation(MeasurementID),
  MeasurementHour time NULL,
  TemperatureCelsius decimal(3,1) NULL,
  ChanceOfRainPercent int NULL
  CHECK(ChanceOfRainPercent >= 0 AND ChanceOfRainPercent <= 100),
  PressureHectopascals decimal(6,2) NULL
)

INSERT INTO MeasurementDetailsHour (DateID, MeasurementID, MeasurementHour, TemperatureCelsius, ChanceOfRainPercent, PressureHectopascals)
VALUES (1,1,'09:01',5,66,1018.52),
	   (1,1,'15:18',14,71,1027.31),
	   (1,1,'21:00',9,45,1022.27),

	   (2,2,'06:04',7,19,998.62),
	   (2,2,'15:15',18,10,1002.06),
	   (2,2,'20:08',10,8,1003.41),

	   (3,3,'08:21',8,6,1011.86),
	   (3,3,'14:12',21,7,1012.95),
	   (3,3,'20:25',13,11,1017.65),

	   (4,4,'09:52',11,29,1023.15),
	   (4,4,'14:27',19,31,1027.00),
	   (4,4,'21:03',16,15,1030.46),

	   (5,5,'10:39',10,14,1004.94),
	   (5,5,'14:43',22,12,1000.98),
	   (5,5,'20:22',15,23,996.35),

	   (6,6,'09:38',5,62,1009.48),
	   (6,6,'16:54',17,51,1010.10),
	   (6,6,'22:10',10,37,1011.31),

	   (7,7,'09:28',10,72,1018.36),
	   (7,7,'14:13',14,78,1013.49),
	   (7,7,'20:49',12,86,1009.15),

	   (8,8,'05:41',0,35,1011.52),
	   (8,8,'11:09',3,42,1012.14),
	   (8,8,'19:36',9,19,1016.87),

	   (9,9,'09:35',9,15,1028.83),
	   (9,9,'14:07',23,51,1031.54),
	   (9,9,'18:46',18,26,1033.59),

	   (10,10,'09:00',12,7,986.11),
	   (10,10,'14:00',31,9,999.23),
	   (10,10,'20:00',26,23,1003.16),

	   (11,11,'09:30',14,2,1024.06),
	   (11,11,'14:00',24,5,1026.57),
	   (11,11,'19:04',20,8,1026.93),

	   (12,12,'06:33',-5,25,1008.65),
	   (12,12,'12:00',3,43,1009.42),
	   (12,12,'21:08',-1,40,1011.16),

	   (13,13,'04:12',1,12,1014.56),
	   (13,13,'12:56',20,27,1015.64),
	   (13,13,'20:05',9,16,1020.69),

	   (14,14,'09:48',7,5,1009.12),
	   (14,14,'14:40',17,15,1008.63),
	   (14,14,'21:03',11,12,1007.11),

	   (15,15,'07:02',16,9,1019.34),
	   (15,15,'13:19',28,33,1010.11),
	   (15,15,'22:00',22,13,1012.98),

	   (16,16,'08:20',13,28,1012.87),
	   (16,16,'16:00',29,11,1008.62),
	   (16,16,'20:59',24,9,1009.46),

	   (17,17,'07:16',-2,81,1000.69),
	   (17,17,'13:34',6,90,1006.74),
	   (17,17,'21:55',1,95,1007.33)

SELECT * FROM WeatherStation
SELECT * FROM Clouds
SELECT * FROM MeasurementDetailsDay
SELECT * FROM MeasurementDetailsHour

DROP TABLE WeatherStation
DROP TABLE Clouds
DROP TABLE MeasurementDetailsDay
DROP TABLE MeasurementDetailsHour

/*Да се напише заявка, която извежда всички дати, на които е направено повече от едно измерване, както и броят им за съответната дата.*/
SELECT MeasurementDate, COUNT(*) AS Measurements
FROM WeatherStation
GROUP BY MeasurementDate
HAVING COUNT(*) > 1

/*Да се напише заявка, която изчислява разликата между датата, на която е измерена най-ниската температура и датата, на която е 
измерена най-високата температура.*/
SELECT CONCAT(ABS(DATEDIFF(MONTH, '2022-12-20', '2022-07-03')), ' months') AS DateDifference

/*Да се напише заявка, която да изведе средната, минималната и максималната температура за ден, както и датата на 
направените измервания, подредени във възходящ ред според дневната температура.*/ 
SELECT CAST(AVG(TemperatureCelsius) AS decimal(3, 1)) AS DayTempetarure,
       MIN(TemperatureCelsius) AS MinTemperature, MAX(TemperatureCelsius) AS MaxTemperature, 
  ( SELECT MeasurementDate
    FROM WeatherStation
	WHERE WeatherStation.MeasurementID = MeasurementDetailsHour.DateID )
  AS MeasurementDate
FROM MeasurementDetailsHour
GROUP BY DateID
/*ORDER BY DayTempetarure ASC*/

/*Да се напише заявка, която да изведе идентификатор на измерване, станцията, в която е направено то и скоростта на вятъра, 
класифицирана като безветрие, тих вятър, лек бриз, слаб, умерен, полусилен и силен вятър.*/ 
SELECT MeasurementID, CityStation, WindSpeedMS,
CASE
    WHEN WindSpeedMS <= 0.2 THEN 'Безветрие'
    WHEN WindSpeedMS <= 1.5 THEN 'Тих вятър'
	WHEN WindSpeedMS <= 3.3 THEN 'Лек бриз'
	WHEN WindSpeedMS <= 5.4 THEN 'Слаб вятър'
	WHEN WindSpeedMS <= 7.9 THEN 'Умерен вятър'
	WHEN WindSpeedMS <= 10.7 THEN 'Полусилен вятър'
    ELSE 'Силен вятър'
END AS Wind
FROM WeatherStation
INNER JOIN MeasurementDetailsDay ON WeatherStation.MeasurementID = MeasurementDetailsDay.DateID

/*Да се напише заявка, която да изведе месеца на направеното измерване, средната стойност от процентите за валежи за ден и
възможното количество на валежите за съответната дата, подредени по азбучен ред на месеците.*/ 
SELECT CONCAT(DATENAME(MONTH, MeasurementDate), ' ', DATEPART(YEAR, MeasurementDate)) AS MeasurementMonth, AVG(ChanceOfRainPercent) AS ChanceOfRainPercent,
  ( SELECT Rain
    FROM MeasurementDetailsDay
	WHERE MeasurementDetailsDay.DateID = MeasurementDetailsHour.DateID )
  AS AmountOfRain
FROM WeatherStation
INNER JOIN MeasurementDetailsHour ON MeasurementDetailsHour.DateID = WeatherStation.MeasurementID
GROUP BY DateID, DATENAME(MONTH, MeasurementDate), DATEPART(YEAR, MeasurementDate)
/*ORDER BY DATENAME(MONTH, MeasurementDate) ASC*/

/*Да се напише заявка, която да изведе идентификатор на дата, ограничението за облачна покривка, облачността за дните, когато 
тя е под 30%, подредени по процента облачност на ден.*/
SELECT DateID, PercentSkyCover, CloudCoverPercentage, Cloudiness
FROM MeasurementDetailsDay
INNER JOIN Clouds ON Clouds.PercentSkyCover < '30'
WHERE CloudCoverPercentage BETWEEN 0 AND 30
AND MeasurementDetailsDay.PercentID = Clouds.PercentID 
ORDER BY CloudCoverPercentage

/*Да се добави нова колона RainPercentDay към таблицата MeasurementDetailsDay, която приема средната стойност на процентите валежи на ден.*/
ALTER TABLE MeasurementDetailsDay
ADD RainPercentDay decimal(3, 1) NULL

UPDATE MeasurementDetailsDay
SET RainPercentDay = ( SELECT ROUND(AVG(ChanceOfRainPercent), 0) 
                       FROM MeasurementDetailsHour
					   WHERE MeasurementDetailsDay.DateID = MeasurementDetailsHour.DateID )

ALTER TABLE MeasurementDetailsDay
DROP COLUMN RainPercentDay

/*Да се създаде изглед, който извежда топ 5 дни по продължителност на деня, датата на деня и месеца от датата като цяло число.*/
CREATE VIEW Top5_DayLength
  AS
   SELECT TOP 5 WITH TIES
   DayLength, MeasurementDate, DATEPART(month, MeasurementDate) AS NumberOfMonth
   FROM WeatherStation
   GROUP BY DayLength, MeasurementDate
   ORDER BY DayLength DESC

SELECT * FROM [Top5_DayLength] 

DROP VIEW [Top5_DayLength]

/*Да се създаде процедура, която извежда станцията и броя на направените измервания в съответните станции, които
съдържат буквата „и“ в името си. Ако няма въведени станции да връща броя на редовете от таблицата.*/
CREATE PROCEDURE TotalStationMeasurement
@Station varchar(25)
  AS
   IF @Station IS NOT NULL
   SELECT CityStation, COUNT(*) AS NumberOfMeasurements
   FROM WeatherStation
   WHERE CityStation like @Station + '%'
   GROUP BY CityStation
   ELSE
   SELECT * FROM WeatherStation
   RETURN @@ROWCOUNT

EXECUTE TotalStationMeasurement '%и%'

DROP PROCEDURE TotalStationMeasurement

/*Да се напише многоструктурна функция, която по дадена дата на направено измерване връща таблица, съдържаща скорост на вятъра,
процент облачност, средната температура за деня, средния процент вероятност за валежи, средното въздушно налягане и датата. 
Ако такава дата не е намерена в базата данни, да се изведе подходящо съобщение.*/
CREATE FUNCTION fnGetMeasurementByDate
   (@Date date)
    RETURNS @tblMeasurements table
	(   WindSpeedMS decimal(3,1),
	    CloudCoverPercentage int,
	    TemperatureCelsius decimal(3,1),
        ChanceOfRainPercent decimal(4,0),
        PressureHectopascals decimal(6,2),
		MeasurementDate varchar(60)   )
AS
BEGIN
    INSERT INTO @tblMeasurements
	      (WindSpeedMS, CloudCoverPercentage, TemperatureCelsius, ChanceOfRainPercent, PressureHectopascals, MeasurementDate)
	SELECT WindSpeedMS, CloudCoverPercentage, AVG(TemperatureCelsius), AVG(ChanceOfRainPercent), AVG(PressureHectopascals), MeasurementDate 
    FROM MeasurementDetailsHour 
	INNER JOIN WeatherStation ON WeatherStation.MeasurementID = MeasurementDetailsHour.DateID                                                                                                           
	INNER JOIN MeasurementDetailsDay ON MeasurementDetailsDay.DateID = MeasurementDetailsHour.DateID
	WHERE MeasurementDate = @Date
	GROUP BY WindSpeedMS, CloudCoverPercentage, MeasurementDate

	IF NOT EXISTS (SELECT *
	               FROM @tblMeasurements)
	    INSERT INTO @tblMeasurements (MeasurementDate)
		VALUES ('Измерване на търсената дата не е направено.')
	RETURN
END

SELECT *
FROM fnGetMeasurementByDate('2022-05-14')
	    
DROP FUNCTION fnGetMeasurementByDate

/*Да се създаде тригер, който актуализира колоната RainPercentDay в таблицата MeasurementDetailsDay 
със средната стойност на колоната ChanceOfRainPercent от таблицата MeasurementDetailsHour. Тригерът се стартира след
въвеждане на нови стойности за колоната ChanceOfRainPercent.*/
CREATE TRIGGER DayAffectsPercentage
  ON MeasurementDetailsHour
  AFTER INSERT, UPDATE
AS
  IF @@ROWCOUNT = 0 RETURN
  IF UPDATE(ChanceOfRainPercent)
   BEGIN 
    UPDATE MeasurementDetailsDay
       SET RainPercentDay = ( SELECT ROUND(AVG(ChanceOfRainPercent), 0) 
                              FROM MeasurementDetailsHour
					          WHERE MeasurementDetailsDay.DateID = MeasurementDetailsHour.DateID )
	FROM MeasurementDetailsDay
    INNER JOIN inserted ON MeasurementDetailsDay.DateID = inserted.DateID
   END

INSERT INTO MeasurementDetailsHour (DateID, MeasurementID, MeasurementHour, TemperatureCelsius, ChanceOfRainPercent, PressureHectopascals)
VALUES (5,5,'11:11',7,13,1016.10),
	   (8,8,'17:00',10,36,1019.04),
	   (13,13,'23:25',4,29,1020.72)

DELETE FROM MeasurementDetailsHour
WHERE PressureHectopascals = 1016.10

DROP TRIGGER DayAffectsPercentage