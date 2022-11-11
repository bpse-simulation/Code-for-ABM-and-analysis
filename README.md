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
1. CellBehaviorSimulator  
    Agent-based model for simulation.

2. LeastSquaresMethod  
    Use for estimation of model parameter values.

3. MovementRate  
    Calculate in silico cell movement rate Vm,silico.

4. Normalization  
    Normalize in silico cell movement rate Vm,silico.

5. Classification_jam_unjam  
    Classify each cell into jamming (1) and unjamming (0) state.  
    Add column to output csv file of "FactorClassification" in "CellBehaviorSimulator".

6. CellCount_layer  
    Count total cell number of each layer.

7. CellCount_state  
    Count the cell number of each cell class (C(t)=0-6) in entire calculation space, basal layer, and suprabasal layer.

8. CellCount_jamming_unjamming  
    Count the cell number of each cell state (jamming and unjamming) in 1, 2, 3, 4, 5, 6- layers, respectively.

9. ImageCreator_Projection  
    Create image of average intensity projection of Rjam in each (y, z) coordinates.  
    Create csv file of average intensity projection of Rjam in each (x, y) coordinates.

10. ImageCreator  
    Create image from csv file of average intensity projection of Rjam in each (x, y) coordinates (output of ImageCreator_Projection).

11. POVFileCreator_jamming  
    Create POV-Ray file for visualization of cell class(C(t)).

12. POVFileCreator_epcc_layer  
    Create POV-Ray file for visualization of The ratio of cell-cell connection energy (ε_CC) and number of layers.

## Simulation input of published data
- initialize file of simulation
- input image (binarized image of phase contrast image obtained from in vitro experiment) for initial cell placement.

*Please note that you cannot get exactly same result as published data because of the stochastic rules in the model (e.g. cell migration, cell differentiation).  
**If you execute simulation with this simulation input, the model output will be around 70GB.

## in silico data
Model output and processed data to generate graph or image.
(For Fig 2, 3, 4, 5, and S5 Fig)

## in vitro data
Data for simulation input and estimation of model parameter values. 
(For Fig 2, and S4 Fig)

*The original images used to estimate cell density (used for Fig 2B and C) and the time-lapse phase contrast images used for PIV analysis were obtained in a previous publication.  
  
Baba K, Sasaki K, Morita M, Tanaka T, Teranishi Y, Ogasawara T, et al. Cell jamming, stratification and p63 expression in cultivated human corneal epithelial cell sheets.
Scientific Reports. 2020; 10(1): 9282. https://doi.org/10.1038/s41598-020-64394-6 PMID:32518325
