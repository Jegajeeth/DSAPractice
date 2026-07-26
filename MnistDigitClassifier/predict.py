"""
predict.py
----------
Loads the trained model (mnist_cnn.pth) and shows predictions on a handful
of test images, so you can visually confirm the model works.

Run it with:
    python predict.py

Requires matplotlib (already listed in requirements.txt).
"""

import torch
from torchvision import datasets, transforms
import matplotlib.pyplot as plt

from model import SimpleCNN

MODEL_PATH = "mnist_cnn.pth"
DATA_DIR = "./data"
NUM_SAMPLES = 6


def main():
    device = torch.device("cuda" if torch.cuda.is_available() else "cpu")

    transform = transforms.Compose([
        transforms.ToTensor(),
        transforms.Normalize((0.1307,), (0.3081,)),
    ])
    test_dataset = datasets.MNIST(root=DATA_DIR, train=False, download=True, transform=transform)

    model = SimpleCNN().to(device)
    model.load_state_dict(torch.load(MODEL_PATH, map_location=device))
    model.eval()

    fig, axes = plt.subplots(1, NUM_SAMPLES, figsize=(12, 3))

    for i in range(NUM_SAMPLES):
        image, label = test_dataset[i]
        with torch.no_grad():
            output = model(image.unsqueeze(0).to(device))  # Add batch dimension
            predicted = output.argmax(dim=1).item()

        axes[i].imshow(image.squeeze(), cmap="gray")
        axes[i].set_title(f"True: {label}\nPred: {predicted}")
        axes[i].axis("off")

    plt.tight_layout()
    plt.show()


if __name__ == "__main__":
    main()
