# Relative planet paths visualizer

This app allows visualizing relative paths of planets (or other cellestial bodies, such as moons or stars), with one of them being the "center" or point of view.
I developed this app in highschool, inspired by a physics/astronomics class.

![Screenshot of the Planets app.](./planets-app.png)

## Features
- Add different cellestial bodies and set their parameters, such as distance from its parent and sideric period.
- Set relationships between cellestial bodies (who is orbiting who). Relationships can be nested, for example Earth orbits the Sun and the Moon orbits Earth.
- View the same configuration with different bodies as the center/point of view.
- Save your planet configuration to a file or load your saved planets from a file.
- Export the visualization as an image (PNG or BMP).

## Limiations
- The app assumes all orbits of cellestial bodies are circles
 with the orbited body at the center
- Only supports exporting to bitmap image formats
- Runs only on Windows

## Used technologies
- C#
- Winforms

## Download
*You should't run random [exe files](https://www.reddit.com/r/github/comments/1at9br4/i_am_new_to_github_and_i_have_lots_to_say/) from unknown people on the internet!*
But if you want to download this app nonetheless, you can get the executable from the [***Releases***](https://github.com/daviddostal/planet-paths-visualizer/releases) section of this repository.