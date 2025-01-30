# Realtime Image Simulator

**Author:** *Image-X Institute*

*A tool for simulating online image streams. Useful for testing online (images coming in realtime) modes without actually being online.*

## Setup/Build/Install

*Visual Studio Version: 2022. with .Net Framework 4.8 developer pack installed.*

## Usage

A tool for simulating online image streams. This tool has been used to simulate KIM’s online mode and tested using .tiff images. 

## Patient directory: 
Copy the image folder location and click on Browse to select the folder. Make sure to use Browse button to choose each directory path! Typing in the path text box would not work currently.

## Pretreatment directory: 
Copy the image folder location and click on Browse to select the folder. 

## Treatment arc 1 directory: 
Copy the image folder location and click on Browse to select the folder. 

## Treatment arc 2 directory: 
Copy the image folder location and click on Browse to select the folder. 

It’s ok to fill all three folders with the same path. Hit ‘stop’ when the first folder is done. 
The reason there are four folders is historical as KIM used to read images from those four folders named above.  

## Output directory: 
The location where you want to have the images to be copied over. Browse to select the folder. 

## Image frequency: 
Simulates how frequently a new image would be transferred to the output directory.

## Delay between arcs: 
To pause for a set interval between pretreatment and treatment arc1 and treatment arc2.

## Next image: 
Copy one image and then pause the stream.

## Start: 
Start copying images to the output directory.

## Pause: 
Pause the stream.

## Stop: 
Stop the stream. Then next time it starts, the files would be copied from beginning again (if the output folder is empty). Otherwise it would skip already copied files.



