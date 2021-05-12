# Unity-Virtual-Camera-Prefab
An open source prefab that makes it easy to live stream from a Unity virtual camera into an Agora stream.


## Usage

1. Drag the Agora Virtual Camera Prefab onto the Scene Hierarchy.
![](https://cdn-images-1.medium.com/max/2400/1*htfFBxCHWE_6DWzcyzzpUA.png)

2. Add your Agora AppID and either a temp token or the URL for a token server. The Agora prefab assumes the token server returns the same JSON response as the [Agora Token Server in Golang guide](https://www.agora.io/en/blog/how-to-build-a-token-server-using-golang?utm_source=github&utm_medium=blog&utm_campaign=How_to_Build_a_VR_Video_Chat_App_using_Unitys_XR_framework).

3. Set the Channel Name

4. Drag the various Game Objects from the scene into the Prefab input fields.
![](https://cdn-images-1.medium.com/max/2400/1*up7Ez6wRWuZqHjafwoYw2g.png)