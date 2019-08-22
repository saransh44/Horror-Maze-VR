# Horror-Games
An open source VR Horror project with tutorials and questions in readme to help other perspective developers 
(mainly meant for those who already are literate with c# and Unity but are simply looking for a source to help them figure out how to use Oculus with Unity) 

There really isn't enough good documentation and oculus non-GO tutorials online so hopefully this helps solve some issues for developers. 
Most are sorely outdated so here is a list of those that are still helpful at the august 2019 writing of this readme. 
For any perspective developers struggling to make components work like say UI and Text in the vr display, please don't be shy! Download this opensource project and just click on my assets in my scene001 to see how I did it :) 
Reverse engineering isn't plagerism. We need to help each other. Pass along the knowledge. 

##Basics and Reviews
#### Where did you learn how to integrate Oculus with your unity project?
https://developer.oculus.com/downloads/package/unity-integration/

#### REVIEW: How would you rate the oculus documentation? 
First, finding it is frickin annoying. The unity page doesn't put it underneath the riftSDK section. So here is to making your life easier
https://developer.oculus.com/reference/unity/1.39/
TLDR: Here is a method and one sentance on what it does.

Rating: Barebones. 
Listen. Why? Yes, I know all documentation is just a list of methods followed by short explanations but seeeeeeeee,
this isn't mobile development or web development. This is just a simple download and import, this is game development. 
You. have. to. change. the. native. scripts. in. the. library.
You don't know where to add a method or object without breaking the 200+ line script that you didn't even make. 
Look, bucko: if any documentation needed copious examples and video tutorials, it was this one. 
I see so many people at hackathons grab an oculus and then return it like 4 or 5 hours later because they get extremely frustrated. They dropped the ball on this one. 

#### REVIEW: I saw that there is one not associated with Oculus but a general library for virtual reality called VRTK, what are your thoughts?
So I incorrectly assummed that because its not directly associated with Oculus, it would be the inferior SDK. 
While there might be slightly less functionality in that SDK (I have not tried it) I would definetly have tried it over Oculus SDK if I could rewind time.
There is much more documentation on VRTK than Oculus SDK because they had the good sense to make a youtube channel about it. https://www.youtube.com/watch?v=vH5zHo6qI84


##Graphics and Locomotion
#### Hey, these free assets and lighting look pretty good. What is your secret? 
https://www.youtube.com/playlist?list=PLZ1b66Z1KFKiaTYwyayb8-L7D6bdiaHzc

#### Where should I learn about locomotion and how to stabilize it with my framerate?
https://www.youtube.com/watch?v=sKQOlqNe_WY

##Scripting
#### I'm having a hard time getting enemies to follow me, what assets should I look at to learn how you did it?
Assets > Scripts > ZombieAI

#### My zombie from the free assets in the Unity Store is not moving!!! 
This is actually not a scripting issue but I put the question here because many understandably assume it is. 
Assets > Zombie > Animations > click on the zombie model in question
Then, in the inspector go to rig and change it to legacy. Then import it in. Make sure that the animation you import as well is set to legacy.

#### I'm having trouble 

