# agentX
 - A.I Agent training exploration using Unity's ML agent library.
 - RL learning implementation.
 - Final neural net `agentX.nn` can be found in the results folder.

# Training Area
 - The scene is consisted of an `Agent` (sphere), `Target` (cube) and the floor plane.
 - `Agent` is rewarded 1.0 point if it reaches the `Target` in scene. 

# Training parameters
 - The training parameters can be found in `config/rollerball_config.yaml` file. 
 ```
 behaviors:
  RollerBall:
    trainer_type: ppo
    hyperparameters:
      batch_size: 10
      buffer_size: 100
      learning_rate: 3.0e-4
      beta: 5.0e-4
      epsilon: 0.2
      lambd: 0.99
      num_epoch: 3
      learning_rate_schedule: linear
    network_settings:
      normalize: false
      hidden_units: 128
      num_layers: 2
    reward_signals:
      extrinsic:
        gamma: 0.99
        strength: 1.0
    max_steps: 500000
    time_horizon: 64
    summary_freq: 10000
 ```
 # TensorBoard results

 # Training time comparaison
 ## Single training area
![Reward](https://github.com/namhkoh/agentX/blob/koh-dev/TensorBoard/culmulative.png?raw=true)
 - Check the TensorBoard folder to view all graphs.
 ## Final Results
 |Steps |Policy/Entropy|Environment/Episode Length|Policy/Extrinsic Value Estimate|Environment/Cumulative Reward|Policy/Extrinsic Reward|Losses/Value Loss|Losses/Policy Loss|Policy/Learning Rate|Policy/Epsilon|Policy/Beta |Is Training|
|------|--------------|--------------------------|-------------------------------|-----------------------------|-----------------------|-----------------|------------------|--------------------|--------------|------------|-----------|
|50000 |1.4145449     |15.640599001663894        |-0.14354631                    |0.2699733688415446           |0.2699733688415446     |0.2469888        |0.024367224       |0.00028462472       |0.1948749     |0.0047442573|1.0        |
|100000|1.3957567     |10.868264894374555        |0.31331256                     |0.47709470685971994          |0.47709470685971994    |0.08462792       |0.022649333       |0.00025696118       |0.18565372    |0.0042841206|1.0        |
|150000|1.3791314     |10.478191000918274        |0.55392027                     |0.6751606978879706           |0.6751606978879706     |0.06505795       |0.027594421       |0.00022620882       |0.17540292    |0.0037726057|1.0        |
|200000|1.3657695     |10.16342933690556         |0.7994534                      |0.8814467515070328           |0.8814467515070328     |0.03275415       |0.024637483       |0.00019546025       |0.16515341    |0.003261155 |1.0        |
|250000|1.3522696     |9.03512645523886          |0.9158237                      |0.9682858289843437           |0.9682858289843437     |0.014595896      |0.02276111        |0.00016471805       |0.15490602    |0.0027498095|1.0        |
|300000|1.3442888     |8.099144988175368         |0.9526815                      |0.995997816991086            |0.995997816991086      |0.005348271      |0.02161112        |0.00013397659       |0.14465885    |0.0022384762|1.0        |
|350000|1.3356354     |7.555973981513181         |0.958845                       |0.9984594317014721           |0.9984594317014721     |0.0032097357     |0.02271756        |0.0001032464        |0.13441543    |0.0017273303|1.0        |
|400000|1.3287157     |7.060444874274662         |0.962767                       |0.9993552546744036           |0.9993552546744036     |0.0022787228     |0.022542967       |7.251488e-05        |0.1241716     |0.0012161627|1.0        |
|450000|1.3250042     |6.76001241850357          |0.96425873                     |0.999689537410742            |0.999689537410742      |0.0019425787     |0.023734555       |4.484738e-05        |0.11494911    |0.0007559601|1.0        |
|500000|1.3234497     |6.58150113722517          |0.9658732                      |0.9998483699772555           |0.9998483699772555     |0.0019550868     |0.026965892       |1.7186736e-05       |0.10572888    |0.0002958711|1.0        |

 ## Multiple training areas
 - Future implmentation

# Training view
## Pre-optimization
![Training View](https://github.com/namhkoh/agentX/blob/koh-dev/Thumbnail/thumbnail.png?raw=true)
(https://youtu.be/d-0Xhrpbk4c)
## Post-optimization
https://youtu.be/wvQ8khv_BUk

# Additional implementation 
 - Add complexity in the environment for greater NN model. 
 - Train in parallel training environment to increase learning speed. 
 - Adjust the hyperparaemters to configure decision value and batch size.
 - More sophisticated 3D models and behaviours to carry out.

# Augmented Reality version
 - Experimentation with ARFoundation and ARcore to view the agent.