# Horror-Games
An open source VR Horror project with tutorials and questions in readme to help other perspective developers 
(mainly meant for those who already are literate with c# and Unity but are simply looking for a source to help them figure out how to use Oculus with Unity) 

Most tutorials are sorely outdated so here is a list of those that are still helpful at the august 2019 writing of this readme. 
For any perspective developers struggling to make components work like say UI and Text in the vr display, please don't be shy! Download this opensource project and just click on my assets in my scene001 to see how I did it.
Reverse engineering isn't plagerism. We need to help each other. Pass along the knowledge :)  

# Every VR Dev Section
## Basics and Reviews
#### Where did you learn how to integrate Oculus with your unity project?
https://developer.oculus.com/downloads/package/unity-integration/

#### REVIEW: How would you rate the oculus documentation? 
First, finding it is frickin annoying. The unity page doesn't put it underneath the riftSDK section. So here is to making your life easier: https://developer.oculus.com/reference/unity/1.39/

**Rating:** Barebones. 
Why? Listen. Yes, I know all documentation is just a list of methods followed by short explanations but seeeeeeeee,
this isn't mobile development or web development. This is NOT just a simple download and import, this is game development. 
You. have. to. change. the. native. scripts. in. the. library.
You don't know where to add a method or object without breaking the 200+ line script that you didn't even make. 
Look, bucko: if any documentation needed copious examples and video tutorials, it was this one. Heck, some of the native scripts have glitches in them like OVRgrabber which we will get into later. I see so many people at hackathons grab an oculus and then return it like 4 or 5 hours later because they get extremely frustrated. People are extremely interested in messing around with VR especially in low risk free settings like hackathons but no one likes to be in the woods without a flashlight. They dropped the ball on this one. And before you ask, no the short sample scenes are not enough at all. https://developer.oculus.com/documentation/platform/latest/concepts/book-sampleapp/?locale=en_US
I needed sample scenes that allowed you to grab a gun, push a door, swipe a card, real customized interaction using your hands, etc. You know...immersion past just basic head movement in these samples. For some reason, the samples they have tackle mostly non VR topics like voice chats, Matchmaking, P2P networking, Leaderboards with the closest VR topic being the most basic one being usage of vr camera/player system which mind you is also one of the few topics that does have tutorials by third parties because how are you gonna make a VR game without using a player and camera. 

#### REVIEW: I saw that there is one not associated with Oculus but a general library for virtual reality called VRTK, what are your thoughts?
So I incorrectly assummed that because its not directly associated with Oculus, it would be the inferior SDK. 
While there might be slightly less functionality in that SDK (I have not tried it), I would definetly try it over Oculus SDK if I could rewind time. Why?
There is much more documentation on VRTK than Oculus SDK because they had the good sense to make a youtube channel about it. https://www.youtube.com/watch?v=vH5zHo6qI84
Having slightly more functionality in your SDK is worthless if you don't show your users how to use it. It makes sense too that there would be more tutorials on mobile

#### Alright, so then which SDK+Platform would you say has the most amount of literature online? 
I was surfing youtube, Stack, Reddit, and Unity Forums mostly for my project. I would say that it seems like honestly there is 50X more attention, documentation, and tutorials about Google Cardboard and GearVR (mobile VR). Its also not that suprising if you just think about it. Cheaper VR headsets with no wires (wow!) that rely on smartphones that everyone has would do better with the public and have more online traction. If I had a chance, I would try GearVR and VRTK even if there is a performance drop just because I feel like I could make much more immersive games that uses their motion sensing controllers more than my demo tutorial here just because there would be more tutorials to explain it. 

For my pick on a more powerful headset with a decent amount of online literature, Oculus Go seems to be getting some good traction. In fact as I was searching for tutorials pertaining to the native RiftSDK, Oculus Go links would start coming up towards the middle of the first page to give you an idea of how little people use the riftSDK and develop for the Go instead. Also no wires :)

# Native RiftSDK specific users
## Graphics 
#### Where should I learn about camera work and how to stabilize it with my framerate?
https://www.youtube.com/watch?v=sKQOlqNe_WY
Relevent Asset Group for reverse engineering: OVRPlayerController

#### Hey, these free assets and lighting look pretty good. What is your secret? 
https://www.youtube.com/playlist?list=PLZ1b66Z1KFKiaTYwyayb8-L7D6bdiaHzc Videos 1-5, 9, 10
**Reverse Engineering:** Relevent asset groups are scene001: Mushrooms, Floors, Walls, Roofs, Lights, Enemies

#### My UI and Text is not displaying correctly, what sources did you use?
https://www.youtube.com/watch?v=h7z4E8Qy8Ks&t
**Reverse Engineering:** Relevent asset group is scene001: Canvas & Assets > Scripts > AOpening.cs

## Scripting
#### I'm having a hard time getting enemies to follow me, what assets should I look at to learn how you did it?
**Reverse Engineering:** Assets > Scripts > ZombieAI & scene001 > Enemies asset group
There is currently no online tutorial showing how to make enemies follow you in the native riftSDK. 

#### My zombie from the free assets in the Unity Store is not moving!!! 
This is actually not a scripting issue but I put the question here because many understandably assume it is. 
Assets > Zombie > Animations > click on the zombie model in question
Then, in the inspector go to rig and change it to legacy. Then import it in. Make sure that the animation you import as well is set to legacy.
**Reverse Engineering:** scene001 > Enemies asset group

#### How do I get doors to respond to controllers?



#### I'm having trouble 

There really isn't enough good documentation or tutorials of oculus non-GO online so hopefully this helps solve some issues for developers. 
