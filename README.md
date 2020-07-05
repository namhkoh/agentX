# agentX
 - A.I Agent training exploration using Unity's ML agent library.
 - RL learning implementation.

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
 ![alt-text-1](https://github.com/namhkoh/agentX/blob/koh-dev/TensorBoard/Environment_Cumulative%20Reward.svg "title-1") 
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