# Text Classificator

## Описание

Данный проект обучен для конкретного датасета на языке C#
Приложение определяет эмоциональную окраску текста (позитивный / негативный) и использует для этого наивный байессовский классификатор

В ApplicationRunner.cs есть множество доступных функций, таких как стемминг, леммитизация, функция токенизации, различные опции для исключения и включения редких слов, плохих слов и многое другое, которые можно настроить

Пример запуска программы. Выводится полный цикл от считывания данных до подсчитывания метрик качества. Также здесь выводятся некоторые тексты, которые были неправильно классифицированы

````
[19:26:20 INF] Start
[19:26:21 INF] Reading data
[19:26:21 INF] Split the data into training and validation
[19:26:21 INF] Train model
[19:26:25 INF] Dictionary size: 62589
[19:26:25 INF] Validation
[19:26:25 INF] Step: 0
[19:26:25 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: Although I generally do not like remakes believing that remakes are waste of time; this film is an exception. I didn't actually know so far until reading the previous comment that this was a remake, so my opinion is purely about the actual film and not a comparison.<br /><br />The story and the way it is written is no question: it is Capote. There is no need for more words.<br /><br />The play of Anthony Edwards and Eric Roberts is superb. I have seen some movies with them, each in one or the other. I was certain that they are good actors and in case of Eric I always wondered why his sister is the number 1 famous star and not her brother. This time this certainty is raised to fact, no question. His play, just as well as the play of Mr. Edwards is clearly the top of all their profession.<br /><br />I recommend this film to be on your top 50 films to see and keep on your DVD shelves.
[19:26:27 INF] Step: 100
[19:26:28 INF] Step: 200
[19:26:30 WRN] Text was not recognized correctly
Expected sentiment: Negative, but was: Positive
Text: (First of all, excuse my bad English) Of course only a movie starring Jessica Simpson can include serious goofs like this.. I'm a norwegian and I felt offended and shocked the makers of this movie did not take the time to do their research upon making this American/Norwegian movie. Even Wikipedia is more accurate when it comes to facts about this country.<br /><br />So I'm posting my corrections out of my frustration: -The Country is named Norway, not Norwegia. -Da is Russian, not norwegian. -Norwegian priests never use those black capes with that white paper by the neck as the protestant church is the dominant by far -It's true we have a native traditional folk-outfit (that we only use like twice a year) but the outfit in this movie is more like a German outfit. -I could NOT understand the so called norwegian in this movie.. Jessica was not making any sense.. neighter did the norwegian priests<br /><br />The only thing I recognise is the norwegian flag (and the viking hats, but that's so stereotypic what people think about norway - vikings!:O gosh)<br /><br />Well.. I guess the people who made this film will never read this comment. but at least I cleared some things up and got rid of some of that frustration..!<br /><br />I'm proud of my country and I'd love if people in the US were less stereotypic and more accurate when they talk about this country.<br /><br />That was all.. Lenge leve Norge ! ;p
[19:26:30 INF] Step: 300
[19:26:32 INF] Step: 400
[19:26:33 INF] Step: 500
[19:26:35 INF] Step: 600
[19:26:37 INF] Step: 700
[19:26:38 INF] Step: 800
[19:26:40 WRN] Text was not recognized correctly
Expected sentiment: Negative, but was: Positive
Text: This film is notable for three reasons.<br /><br />First, apparently capitalizing on the success of the two 'Superman' serials, this low budget feature was made and released to theaters, marking George Reeves' and Phyllis Coates' initial appearances as Clark Kent / Superman and Lois Lane. Part of the opening is re-used in the series. Outside the town of Silby, a six-mile deep oil well penetrates the 'hollow Earth' allowing the 'Mole-Men' to come to the surface. Forget about the other holes (those in the plot).<br /><br />Second, unlike most SF invasion films of the fifties, the hero plays a dominant (and controlling) force in preaching and enforcing tolerance and acceptance of difference against a raging mob of segregationist vigilantes. No 'mild mannered reporter' here! Clark Kent, knowledgeable and self-assertive, grabs control of the situation throughout (I'll handle this!), even assisting in a hospital gown in the removal of a bullet from a Mole-Man! As Superman, he is gentler than Clark towards the feisty Lois, but is also the voice of reason and tolerance as he rails against the vigilantes as Nazi storm troopers. <br /><br />Third, you will notice that the transition from the Fleisher-like cartoon animated flying of Superman in the two serials to the 'live action' flying in the 'Adventures of Superman' had not yet been made.
[19:26:40 INF] Step: 900
[19:26:41 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: This was an adorable movie. A real feel-good movie when you need one. The story is light (this is no Gone With the Wind) but sometimes, one needs this kind of plot. Funny and warm characters, fantastic acting and beautiful costumes/wardrobe.<br /><br />Parminder K. Nagra (also from the TV show ER) is WONDERFUL in this role. She is definitely a new shining star for Hollywood. All should keep an eye on her, she's going to be BIG in the future.<br /><br />Also impressing was the soundtrack for this movie. A nice mix of modern and Indian tunes. I was dancing throughout most of the movie.<br /><br />Highly recommended if a fun movie is what you need.
[19:26:42 INF] Step: 1000
[19:26:43 INF] Step: 1100
[19:26:45 INF] Step: 1200
[19:26:45 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: Lately I have been watching a lot of Tom Hanks films and old Chaplin films and even some of Rowan Atkinson's early Bean performances, and it seems that all of them have their own unique charm that permeates throughout their work, something that allows them to identify with audience members of all ages, in a way that just makes you feel good. A Bug's Life has that same charm, it has a connection with real life that allows us to easily suspend disbelief and accept a lot of talking insects, because even though they talk, they still ACT just like real bugs. It's like the team that made the movie found a way to bring us into the mind of a child and allow us to think like them, to imagine bugs the way a young mind does.<br /><br />Honey, I Shrunk The Kids was one of my favorite films when I was younger, and to me, A Bug's Life is like a more realistic version of that movie, if only because the animation is so breathtaking and this style of story-telling just opens up so many more narrative possibilities. I try not to compare it to something like Toy Story (which I still maintain is the best computer animated film ever made), because the story of A Bug's Life is not quite as good as Toy Story's, but then again, almost nothing is. The important thing is that it is still wonderful fun. <br /><br />The story concerns a colony of hard working bugs who have an impressively developed society, mostly geared around building a harvest of food, most of which will go to the tyrannical grasshoppers, vastly superior in strength and general meanness, and hopefully still leave enough left over for the bugs to make it through the winter. We are treated to some visits from the grasshoppers, who make it clear that if the bugs provide an unsatisfactory quantity of food, the consequences will be dire. And incidentally, the similarities between this crippling level of food extraction is strikingly similar to Mao Tse-tung's vicious forcing of food from his own people during the Great Leap Forward <br /><br />The fun and excitement begins when Flik, the main character, sets off on a quest to find a gang of appropriate warrior bugs to come back and help defend the colony against the grasshoppers. You see, he spilled all of the amassed food and placed everyone in great danger, so he feels it's his responsibility, but he inadvertently ends up hiring a struggling group of insect circus performers. Great for the audience, not so great for the safety of the clan. <br /><br />The movie was released back in the late 90s, when so many films seemed to have been coming out in twos, like Armageddon and Deep Impact, Independence Day and The Arrival, A Bug's Life and Antz, etc. Comparisons between A Bug's Life and Antz are inevitable, although it seems clear to me that A Bug's Life is by far the superior film, and not only because it doesn't star Woody Allen stuttering and whining through the lead role. This is great family fun!
[19:26:47 INF] Step: 1300
[19:26:47 WRN] Text was not recognized correctly
Expected sentiment: Negative, but was: Positive
Text: This movie was a long build-up with no climax. People whom refer to the swordfight in the end as great must either be out of their minds, or have none. Way too often this movie got soft. I am not saying that soft movies are bad. But no matter how fond you are of sugar it should have no space on a T-bone steak. This movie was supposed to be about vengeance for crimes committed against a culture, but it ended up being a petty bar-brawl. And there was only one of them who actually knew what a sword was; Tim Roth's character (and yes, he plays him well). Rob Roy was a weak hero with no knowledge of how to use a sword, and the way he won was a disgrace. As a drama this movie had it's periods, but the best performance in it has to go the nature of Scotland. This is one tad breath short of being termed as soap in my book.
[19:26:48 INF] Step: 1400
[19:26:50 INF] Step: 1500
[19:26:52 INF] Step: 1600
[19:26:53 INF] Step: 1700
[19:26:55 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: And yet another run of South Park comes to an end. This wasn't as strong an episode as I'd hoped for, but Night of the Living Homeless was a stronger finisher then Stanley's Cup, Tsst, Bloody Mary, or Erection Day. It still can't hold a candle to Woodland Critter Christmas and Goobacks, but few episodes can.<br /><br />Night of the Living Homeless is a spoof of the zombie genre, done in a way only South Park would think of. Instead of flesh eating zombies, the entities are homeless that request change and seem to survive off of it.<br /><br />Randy and other residents are locked in the Community Center, though this time on the roof, where they can survey the scene. A particularly funny moment is when one member finds out his home is gone, and becomes homeless, leaving Randy no choice but to shoot him.<br /><br />Meanwhile, the four boys set out to solve the problem, with the whole story behind the homeless takeover trying to convey a message, but being seriously uninspired. South Park is at it's best a lot of the times when it is being ridiculous. Matt and Trey played it safe this week, and didn't really critique the homeless problem, just lampooned it.<br /><br />The shock moment of the episode comes when a scientist shoots himself in an attempt to avoid the homeless. This is the first time a suicide on South Park goes wrong, and we watch the poor man miss his brain and then attempt to shoot himself many times while he painfully dies. Another inspired South Park moment.<br /><br />Overall, the episode was funny, but it was kept from being great by withholding any real commentary on the homeless and sticking straight with the zombie shtick. The ending is somewhat funny, but nothing new.<br /><br />Now we must wait until October for the next batch of episodes. It's a long haul, but South Park must be applauded for it's run. The show seemed to be running out of steam last season, but now it's back in full form.
[19:26:55 INF] Step: 1800
[19:26:57 INF] Step: 1900
[19:26:58 INF] Step: 2000
[19:27:00 INF] Step: 2100
[19:27:02 INF] Step: 2200
[19:27:03 INF] Step: 2300
[19:27:05 INF] Step: 2400
[19:27:07 INF] Step: 2500
[19:27:09 INF] Step: 2600
[19:27:10 INF] Step: 2700
[19:27:12 INF] Step: 2800
[19:27:14 INF] Step: 2900
[19:27:15 INF] Step: 3000
[19:27:16 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: I really enjoyed the pilot, it was as amazing as I hoped it would be, if not better. Patrick Warburton was a riot, although at first i thought that I wouldn't be able to stand his character. Him and Megyn Price Had little chemistry at all, but hopefully as the season goes on they'll get more comfortable around each other. It must have been weird for Megyn to go from being the star on her last show [Grounded For Life] to being a co-star. <br /><br />Bianca Kajlich and Oliver Hudson seem really new to the whole Sitcom scene, but I think in time they'll get better. David Spade's character, to my surprise, wasn't the whole focus of this pilot. The way he delivers his lines is so different from anyone else i've ever seen on TV, but I think that it is just his style. It works for him.<br /><br />I think that couples, or even singles, will be able to relate to all the doubts and fights and being unsure about your decisions, that this show is about. All the situations that the characters are put in just feel like real life, not sugar-coated like most shows.<br /><br />I hope for all the actors sakes that CBS gives them a chance. This show has the potential to be one of the best series, if just given the chance and time.
[19:27:17 INF] Step: 3100
[19:27:18 WRN] Text was not recognized correctly
Expected sentiment: Negative, but was: Positive
Text: This series was CBS networks answer to the success of the Big Valley. It was a 90 minute Western just like the ABC program was. While it was an answer, it did not have the stuff to make it past season 2.<br /><br />The problem really became reality got lost on this show. For example- in one episode, Johnny gets his eye poked out by a stick. Amazingly, by the end of the show, Johnny had healed entirely. Along with that, the stories on this were no where near as strong as The Big Valley.<br /><br />This is a show that I would not want DVDs of, & frankly hope they are never released. Think since CBS was running out of lots, they re-used many familiar settings. This was one the last western series CBS produced as westerns were not real popular in the 1970's.
[19:27:19 INF] Step: 3200
[19:27:20 INF] Step: 3300
[19:27:22 INF] Step: 3400
[19:27:24 INF] Step: 3500
[19:27:25 INF] Step: 3600
[19:27:27 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: Well, I would consider Police Story as one of Jackie Chan's best film. The plot, the fighting scenes and the stunt works are excellent. In this film, Jackie himself acted as a police officer called Chan Ka Kui (Kevin Chan in some versions) who successfully arrested a crime lord. After the crime lord was released due to lack of evidence , he framed Chan for the killing of a police officer. Due to this, he became wanted by the police. Later on, Salina (Brigitte Lin), who was the secretary of the crime lord, went to a shopping mall and started to steal the evidence of the crime lord's crimes from his computer and preparing to pass them to Chan. However, the crime lord knew that Salina had downloaded his incriminating data and hired his henchmen to capture her. Later on, Chan appeared at the scenes and began to fight all of the henchmen, defeating them one by one. At the last scene, Chan was seen punching the crime lord. Lastly, this is the best action and comedy movie. Everyone should watch it. Highly recommended.
[19:27:27 INF] Step: 3700
[19:27:27 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: With such actors as Ralph Richardson, Raymond Massey, Cedrick Hardwicke, and Margaretta Scott, how can you go wrong. Very unusual scenics, especially the modern ones. The realization of the modern machinery is very effective. Here you have ray-gun blasts from building vehicles that help clear the area, so new structures can be made. Although she's much younger in this film, It's not very hard to figure out who the future Mrs. Pumphrey from the BBC series, All Creatures Great and Small is going to be! Really effective reappearance of both Raymond Massey and Ralph Richardson. The musical score is by the renowned Swiss composer, Artur Honegger and it is also unusual. For the time (1936) it looks like they used really, large sets or the effects make it seem that way. Lastly, it's a really good story.
[19:27:29 INF] Step: 3800
[19:27:31 INF] Step: 3900
[19:27:32 INF] Step: 4000
[19:27:33 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: most of the bad reviews on this website blame Hood of the Living Dead for one (or more) of the following reasons: 1) it is a low-budget movie with virtually no acting; 2) it was so bad it made me laugh 3) it is something I could do myself. I won't even discuss the first point because it is a very subjective matter whether you like low-budget and independent stuff or not. I must say, however, that I still fail to understand people renting such a movie as Hood of the Living Dead and then looking surprised when they realize it is not as polished and cute as a romantic comedy with Lindsay Lohan or Matthew Mc Conaughey. As for the second point, I really don't see what's so wrong with laughing. I personally like to laugh, and love movies that make me to, be they comedies or horror flicks. When in Hammerhead I saw this girl stepping into a PUDDLE and the shark-man came out of it to eat her, I just cracked up. And I was grateful that the director made such a stupid scene and gave me ten seconds of pure fun. Honestly, laughing just makes me feel good, while it seems that many people writing reviews see it as a bad bad thing. If you only want to feel sad and scared while watching a movie, Hood of the Living Dead and low-budget flicks are definitely not for you. But please don't come and tell us that you find them laughable. We already know it. This is most probably why we decided to watch the movie in first place. However, it is the third point that leaves totally baffled. Just several years ago people were lining up out of theaters to see Blair Witch Project, which is a way more rudimentary, boring, plot-less and bad-acted movie than Hood of the Living Dead (and takes itself way too seriously too). Moreover, half a million people go on YouTube every day to see the short films of Lonelygirl15, which is certainly something everyone with a cute girlfriend, a room and a webcam could do! Not to talk about all of the even more amateurish videos you can find there. Why don't people blame those clips for bad acting and non-existing plot? I think it is one of the best things of our times that everyone, with affordable technology and a bunch of friends, can make their own movies and share them with people that have similar interests. And I feel a certain admiration for people who spend their weekends with their friends making a honestly bad (yet refreshing) piece of trash like this rather than shopping at the mall or playing video games alone. Leave aside your biases and your desire to sound like a smart film critic by attacking b-movies, and you'll see that Hood of the Living Dead can bring you almost as much fun as it did to its makers! If you have a taste for refreshing and enjoyable home-made horror movies, I recommend Zombiez, The Ghosts of Edendale, The Killer Eye, Monster Man, Don't Look in the Basement, The Worst Horror Movie Ever Made, Redneck Zombies, Jesus Christ Vampyre-Slayer and Habit.
[19:27:34 INF] Step: 4100
[19:27:36 INF] Step: 4200
[19:27:37 INF] Step: 4300
[19:27:39 INF] Step: 4400
[19:27:41 INF] Step: 4500
[19:27:42 INF] Step: 4600
[19:27:44 INF] Step: 4700
[19:27:46 INF] Step: 4800
[19:27:47 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: When I watched this film the first time, it was a taped copy and the title was/is Caged Terror. I still own the tape, and I confess, I've watched it more than once from beginning to end! The film is extremely low budget and the dialogue is often unintentionally amusing! I have gotten a few of my friends to watch this and we've had some great laughs from the terrible script. The film concerns a couple, (remember this is like early 70's so they are just too hip man!) who go on a week-end camping trip in what I believe was supposed to be upstate NY. They have some hilarious dialogue after catching and eating a fish and the girl bemoans the death of the fish and that they ate it! The guy comes back with something goofy about how they ate the fish and now it was a part of them, and he goes; And that's beautiful man! Heavy man, really heavy! LOL! Anyway, along come a couple of Vietnam vets, one of who plays the flute, I believe. (At any rate they are musical fellows!) The guys are clearly attracted to the girl and when the couple prove unfriendly, they end up terrorizing them during the night. The guy ends up caged in a chicken coop, and has to watch his girl friend being ravished by the two guys. Actually, by the end of the night, she seems to be pretty into it, and when morning comes, the guys leave and the girl and guy are free to leave. Supposedly the guy has learned a lesson about how to treat people, and the girl has a smile on her face! :) Anyway, I would recommend this film highly to anyone looking for a damn good laugh! It never fails to amuse me anyway! If I could find this on DVD and replace my old tape copy, I'd actually buy it again, it's classic camp! You gotta love this stuff!
[19:27:47 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: SPOILERS<br /><br />Tom and Jerry is a classic cartoon, with a flawless idea, and almost every single short is a gem. While I must say that this is definitely an inferior short compared such other classic Tom and Jerry shorts, there is not way you can hate this cartoon. Sure, it is understandable to say that this is one of the worst of the first Tom and Jerry episodes, and I can say that I agree, but the fact of the matter is that all Tom and Jerry episodes are great, but some are just better than others. Well, this would fit into others. <br /><br />Here is the plot of Fraidy Cat. Tom is listening to an old scary radio broadcast, and becomes easily frightened. Jerry observes how scared he is, and tries to scare him even more than he already is. He creates scary dilemmas for Tom, and Tom becomes scared out of his wits, and his lives. Jerry then puts a sheet over a vacuum cleaner and controls it, thus making it look like the vacuum is a ghost. Tom finds out that Jerry did all of this, and chases him. Tom then accidentally bites the house maid. However, at the end Jerry ends up the one becoming scared after he sees his reflection in a flour cup.<br /><br />Overall, this is far from the best Tom and Jerry short out there, but this is still a fun and entertaining piece of time. It makes me wish that there was more cartoons like this. The slapstick and gags in this that make Tom and Jerry famous are as good as ever in this short, but it felt like something was missing in this. It felt slower than most Tom and Jerry shorts. Anyway, this is a good short that does not quite live up to some other Tom and Jerry cartoons, but it is still nice.<br /><br />7/10
[19:27:47 INF] Step: 4900
[19:27:49 INF] Step: 5000
[19:27:51 INF] Step: 5100
[19:27:53 INF] Step: 5200
[19:27:54 INF] Step: 5300
[19:27:54 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: This is a very intriguing short movie by David Lynch, and saying the name David Lynch is probably enough for a lot of people. This is your typical Lynch short. A blonde and a brunette are in a dark room. The blonde has been crying, the brunette is talking in a threatening way to the blonde, and that's about it.<br /><br />With a lot of silent moments, but with the haunting music from Angelo Badalamenti, there is a strange form of suspense. This short feels a little like 'Mulholland Dr.', a movie I loved, and therefore I liked this one as well. It is probably especially for Lynch fans but there is a chance you like this.
[19:27:56 INF] Step: 5400
[19:27:58 INF] Step: 5500
[19:27:59 INF] Step: 5600
[19:28:01 INF] Step: 5700
[19:28:03 INF] Step: 5800
[19:28:03 WRN] Text was not recognized correctly
Expected sentiment: Positive, but was: Negative
Text: I contend that whoever is ultimately responsible for creating/approving the trailer for this movie has completely blundered. NO ONE I know wanted to see this movie based on the previews, and EVERYONE who actually saw it (that I know) absolutely loved it... The advertising campaign is disgrace/disaster/blunder.<br /><br />Opened at #4 behind...<br /><br />#1-Rush Hour, which I have not seen, average IMDb score of 7.4.<br /><br />#2-The Bourn Ultimatum, which I have seen, awesome movie but 3rd week out, average IMDb score of 8.7 (deserving I would say).<br /><br />#3-The Simpsons Movie, which I have seen, okay movie but 4th week out, average IMDb score of 8.1 (a bit high in my opinion).<br /><br />#4-Stardust, average IMDb score of 8.4 (lower then Bourn, but that's been our for 3 weeks).<br /><br />Whether it was poor scheduling or poor advertising I think that the powers that be behind this movie screwed up big time! This should have been advertised as an amazing movie that happens to be a fantasy/fairytale and not advertised as just another fairytale  Too bad :( Anyway- Now that I have very pointlessly ranted on-and-on... Awesome movie, go see it!
[19:28:04 INF] Step: 5900
[19:28:06 INF] Step: 6000
[19:28:08 INF] Step: 6100
[19:28:09 INF] Step: 6200
[19:28:10 INF] Quality Metrics
    
    Accuracy: 0,67024

    Balanced Accuracy: 0,6700100885316783
    
    ConfusionMatrix: 
    1839 1277
    784 2350

    +Precision: 0,70110560426992
    +Recall: 0,5901797175866496
    
    -Precision: 0,6479183898538737
    -Recall: 0,7498404594767071

    +F-Measure: 0,640878201777313
    -F-Measure: 0,6951634373613371
```