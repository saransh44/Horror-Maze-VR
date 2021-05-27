# Horror-Games
An open source VR Horror project made with Unity's native RiftSDK with general to specific questions in readme for all kinds of perspective VR developers (mainly meant for those who already are literate with c# and Unity but need some VR pointers) 

Most tutorials are sorely outdated so here is a list of those that are still helpful at the august 2019 writing of this readme. 
For any perspective developers struggling to make components work like say UI and Text in the vr display, please don't be shy! Download this opensource project and just click on my assets in my scene001 to see how I did it.
Reverse engineering isn't plagerism. We need to help each other. Pass along the knowledge :)  

# For All VR Devs
## Basics and Reviews
#### Where did you learn how to integrate Oculus with your unity project?
https://developer.oculus.com/downloads/package/unity-integration/

#### REVIEW: How would you rate the native RiftSDK + documentation? 
First, finding the docs is frickin annoying. The unity page doesn't put it underneath the native riftSDK section. So here is to making your life easier: https://developer.oculus.com/reference/unity/1.39/

**native RiftSDK:** Good in a vacuum but subpar in context if you continue reading :(
**native RiftSDK Documentation:** Barebones. 
Why? Listen. Yes, I know all documentation is just a list of methods followed by short explanations but seeeeeeeee,
this isn't mobile development or web development. This is NOT just a simple download and import, this is game development. 
You. have. to. change. the. native. scripts. in. the. library.
You don't know where to add a method or object without breaking the 200+ line script that you didn't even make. 
Look, bucko: if any documentation needed copious examples and video tutorials, it was this one. Heck, some of the **few native scripts have glitches** in them like in the grabber scripts which we will get into later. I see so many people at hackathons grab an oculus and then return it like 4 or 5 hours later because they get extremely frustrated. People are extremely interested in messing around with VR especially in low risk free settings like hackathons but no one likes to be in the woods without a flashlight. They dropped the ball on this one. And before you ask, no the short sample scenes are not enough at all. https://developer.oculus.com/documentation/platform/latest/concepts/book-sampleapp/?locale=en_US
I needed sample scenes that allowed you to grab a gun, push a door, swipe a card, real customized interaction using your hands, etc. You know...immersion past just basic head movement in these samples. For some reason, the samples they have tackle mostly non VR topics like voice chats, Matchmaking, P2P networking, Leaderboards with the closest VR topic being the most basic one being usage of vr camera/player system which mind you is also one of the few topics that does have tutorials by third parties because how are you gonna make a VR game without using a player and camera. So how good is your sdk, if you don't effectively communicate how to use all its wonderful features?

#### REVIEW: I saw that there is one not associated with Oculus but a general library for virtual reality called VRTK, what are your thoughts?
So I incorrectly assummed that because its not directly associated with Oculus, it would be the inferior SDK. 
While there might be slightly less functionality in VRTK (I have not tried it), I would definetly try it over Oculus SDK if I could rewind time. Why?
There is much more documentation on VRTK than Oculus SDK because they had the good sense to make a youtube channel about it. https://www.youtube.com/watch?v=vH5zHo6qI84
Again, having slightly more functionality in your SDK is worthless if you don't show your users how to use it. 

#### Alright, so then which SDK+Platform would you say has the most amount of literature online? 
I was surfing youtube, Stack, Reddit, and Unity Forums mostly for my project. I would say that it seems like honestly there is 50X more attention, documentation, and tutorials about Google Cardboard and GearVR (mobile VR). Its also not that suprising if you just think about it. Cheaper VR headsets with no wires (wow!) that rely on smartphones that everyone has would do better with the public and have more online traction. If I had a chance, **I would try GearVR and VRTK** even if there is a performance drop just because I feel like I could make much more immersive games that uses their motion sensing controllers more than my demo tutorial here just because there would be more tutorials to explain how to do those cool immersion tricks. 

For my pick on a more powerful headset with a decent amount of online literature, Oculus Go seems to be getting some good traction. In fact as I was searching for tutorials pertaining to the native RiftSDK, Oculus Go links would start coming up towards the middle-endish of the first page to give you an idea of how little people use the riftSDK and develop for the Go instead. Also no wires :)

I didn't really see too many tutorials when it came to the rift or rift s and VRTK so I don't have strong opinions on that especially since I haven't used VRTK.

# For Native RiftSDK Specific Users
## Immersion
#### How do I interact with guns, grab from both hands, and snap grab to certain points?
Remember when I said you have to change native script files when doing real interaction with the wonderful touch controllers and thats why Oculus should have had video tutorials? Well this is the example. 
Here is the 3rd party video that explained it: https://www.youtube.com/watch?v=98gfkursxYI
**Reverse Engineering:** Assets > Scripts > ShootIfGrabbed & scene001 > Handgun_M1911A_Black (WithScript) & CustomHandRight + OVRGrabber.cs
I wanted to grab the gun instead of distance grab as shown in that video so look at my OVRgrabber.cs for the changes so that you can grab to both hands and snap to certain grab points like a pro.
Remember to modify the simpleshoot.cs that is provided with handgun prefab as per that above video details.

#### How do I get doors to respond to controller inputs?
There isn't a nativeRift sdk tutorial on this yet :(
**Reverse Engineering:** scene001 > Doors asset group & Assets > Scripts > DoorCellOpen.cs and PlayerCasting.cs
If you are interested in the non VR tutorial I used to figure this out here: https://www.youtube.com/watch?v=HhFoFWjR2WA&list=PLZ1b66Z1KFKiaTYwyayb8-L7D6bdiaHzc&index=7&t=0s
For controller inputs, here: https://docs.unity3d.com/Manual/OculusControllers.html

#### How do I do grabs distance or grabbable with CustomHands following my OVRPlayer?
https://www.youtube.com/watch?v=rnOR1OANIAU&t

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

## VR Scripting Issues
#### I'm having a hard time getting enemies to follow me, what assets should I look at to learn how you did it?
**Reverse Engineering:** Assets > Scripts > ZombieAI & scene001 > Enemies asset group
There is currently no online tutorial showing how to make enemies follow you in the native riftSDK. 

#### My zombie from the free assets in the Unity Store is not moving!!! 
This is actually not a scripting issue but I put the question here because many understandably assume it is. 
Assets > Zombie > Animations > click on the zombie model in question
Then, in the inspector go to rig and change it to legacy. Then import it in. Make sure that the animation you import as well is set to legacy.
**Reverse Engineering:** scene001 > Enemies asset group


## VR Hardware Troubleshooting
#### I keep on getting black screens!?
Yea. No. I wasn't kidding the Oculus Rift S is a messy buggy piece of shit sometimes. They really outta have tested the device more. Here are 7 things to try:
1. Check all wires? No cuts. No loose ones?
2. Make sure all detection is picked up in oculus app with green check marks
3. Check your Nvidia Optimus settings so that the right graphics card is being picked up in Nvidia Control Panel
4. Make sure oculus is recognized in Device Manager and check the error log by clicking on the device in manager
5. Update all drivers from Nvidia to Oculus to BIOS
6. Roll back Winsows(Few times this is the issue esp with 20H2 according to few reddit users)
7. Try disabling your IGPU in device manager > display adapters so that your DGPU is forced to take over. You can reenable the IGPU later. (This is what worked for me)

#### Sometimes, Oculus stops responding?
Make sure USB suspend settings are off in your power plans

#### Slow video speed and responsiveness?
If your system can afford it, try increasing VRAM in BIOS which helps the GPU. I had to do this actually. Know that in some systems with IGPUs mostly, allocating more VRAM means less available for the system. Online material on VRAM and RAM is slightly confusing. DGPU's have their own VRAM. IGPU's require a little more setting management. I have an excellent Asus ROG gaming laptop with 6GB 1660TI DGPU. I still had to increase my VRAM bios setting because VRAM helps with texture mapping and in the 3D VR world, its important to have things rendered so that they look good yes, but also having more information in the closest memory access space of VRAM means that when trying to do collisions on the texture mapping, this process is simply faster. VRAM does help with performance not just graphical looks depsite what old internet articles might say about it because most of them aren't considering the interactive graphical nature of VR.

#### Overheating?
Get a laptop fan. 
Try a power USB hub with an external power adapter to mitigate the load of your laptop a little.
Also don't be stupid. Monitor and turn it off after an hour of intense VR gaming if it is still running hot.
