# MNIST Digit Classifier (Phase 2 Starter Project)

Your first deep learning project: a Convolutional Neural Network (CNN) that
recognizes handwritten digits (0-9) using the classic MNIST dataset.

This maps to **Phase 2 — Deep Learning** in [AI-Learning-Roadmap.md](../AI-Learning-Roadmap.md).

## Project structure

```
MnistDigitClassifier/
  requirements.txt   # Python dependencies (torch, torchvision, matplotlib)
  model.py           # The CNN architecture, with beginner-friendly comments
  train.py           # Downloads MNIST, trains the model, evaluates, saves weights
  predict.py         # Loads the trained model and visualizes predictions
  README.md          # This file
```

## Prerequisite: Install Python

Python was not detected on this machine. Install Python 3.11+ from
https://www.python.org/downloads/ (check "Add python.exe to PATH" during setup),
then re-open a new terminal so PATH changes take effect.

Verify it worked:
```powershell
python --version
```

## Setup

From inside the `MnistDigitClassifier` folder:

```powershell
# 1. Create an isolated virtual environment (keeps dependencies separate per project)
python -m venv .venv

# 2. Activate it
.venv\Scripts\Activate.ps1

# 3. Install dependencies
pip install -r requirements.txt
```

> If PowerShell blocks the activation script, run:
> `Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser`

## Train the model

```powershell
python train.py
```

This will:
- Automatically download the MNIST dataset into `./data` on first run (~10 MB)
- Train for 5 epochs (full passes over the training data)
- Print training loss and test accuracy after each epoch
- Save the trained weights to `mnist_cnn.pth`

Expect roughly **98-99% test accuracy** — a great first deep learning result.

## Visualize predictions

```powershell
python predict.py
```

Shows 6 sample test digits alongside the model's predicted label.

## What to try next

- Change `EPOCHS`, `LEARNING_RATE`, or the CNN architecture in `model.py` and see
  how accuracy changes.
- Try feeding in your own handwritten digit (photo, cropped to 28x28 grayscale).
- Once comfortable, move to Phase 2's other project: an image classifier for a
  custom dataset (e.g., cats vs dogs) using transfer learning.
