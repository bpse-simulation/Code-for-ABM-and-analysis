# Code-for-ABM-and-analysis
Elucidation of chain migration-driven jamming-unjamming transition in corneal epithelial cell sheet using an agent-based approach (code and data files)

# Cell Behavior Simulator (Agent-based model)
The simulation was executed using "CellBehaviorSimulator" in "Code" directory.
## How to run the simulator
1. Click "File(F)" tab 
2. Click "Open(O)"
3. Select "initialize" file
4. Click "Operations" tab
5. Click "..." under description of "Load image path"
6. Select "input_image" file
7. Click "Output" tab
8. Click "..." under description of "Output path"
9. Select directory for model output
10. Click "start" button

*You can change parameters about number of cell types, cell properties, seeding condition, etc.

## Code
Code of agent-based model and analysis.

## in silico data
Model output and processed data to generate graph or image.
(For Fig 2, 3, 4, 5, and S5 Fig)

## in vitro data
Data for simulation input and estimation of model parameter values. 
(For Fig 2, and S4 Fig)

*The data of cell density (used for Fig 2B and C) is obtained in a previous pablication.
Baba K, Sasaki K, Morita M, Tanaka T, Teranishi Y, Ogasawara T, et al. Cell jamming, stratification and p63 expression in cultivated human corneal epithelial cell sheets.
Scientific Reports. 2020; 10(1): 9282. https://doi.org/10.1038/s41598-020-64394-6 PMID:32518325

## Simulation input
- initialize file of simulation
- input image (binarized image of phase contrast image obtained from in vitro experiment) for initial cell placement

*Please note that you cannot get exactly same result as published data because of the stochastic rules in the model (e.g. cell migration, cell differentiation).