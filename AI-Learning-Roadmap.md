# AI Learning Roadmap: Beginner to Advanced

> Built for a developer with a strong programming/DSA background (C#) who is starting fresh in AI.

---

## Phase 0 — Prerequisites

| Topic | Why it matters |
|---|---|
| **Python** | The de facto language for AI (libraries, community, tooling). Your C#/algorithms background transfers fast. |
| **Math basics**: Linear Algebra (vectors, matrices, dot products), Statistics & Probability (mean, variance, distributions, Bayes theorem), Calculus (derivatives, gradients) | Needed to understand *why* models learn, not just how to call `.fit()`. |
| **Git & command line** | You likely already know this. |

**Mini project:** Rewrite 2-3 of your existing DSA solutions (e.g., MergeSort, Palindrome check) in Python — builds Python fluency fast without learning new logic.

---

## Phase 1 — Machine Learning Foundations

**Concepts:**
- Supervised vs unsupervised vs reinforcement learning
- Regression (linear, logistic) and classification
- Decision trees, random forests, k-NN, k-means clustering
- Train/test split, cross-validation, overfitting/underfitting
- Evaluation metrics: accuracy, precision, recall, F1, ROC-AUC, MSE

**Tools:** NumPy, pandas, matplotlib/seaborn, scikit-learn

**Resources to look up:** Andrew Ng's *Machine Learning Specialization* (Coursera), *Hands-On Machine Learning with Scikit-Learn, Keras & TensorFlow* (book by Aurélien Géron)

**Projects:**
1. House price prediction (regression) using a public housing dataset
2. Titanic survival classifier (classic beginner Kaggle dataset)
3. Customer segmentation with k-means clustering on retail data

---

## Phase 2 — Deep Learning

**Concepts:**
- Neural network fundamentals: neurons, activation functions, forward/backward propagation, gradient descent, backpropagation
- Loss functions and optimizers (SGD, Adam)
- CNNs (image processing)
- RNNs/LSTMs (sequential data — before Transformers took over)
- Regularization: dropout, batch normalization

**Tools:** PyTorch (recommended — more common in research/industry now) or TensorFlow/Keras

**Resources to look up:** fast.ai course, *Deep Learning Specialization* (Andrew Ng, Coursera), PyTorch official tutorials

**Projects:**
1. Handwritten digit recognizer (MNIST) — the "hello world" of deep learning
2. Image classifier for a custom dataset (e.g., cats vs dogs, or your own photos) using CNN + transfer learning
3. Simple text sentiment classifier using an LSTM

---

## Phase 3 — Specializations

Pick a track (or explore both — many roles blend them):

### Track A: NLP & Transformers
- Tokenization, embeddings (Word2Vec, GloVe)
- Attention mechanism and the Transformer architecture ("Attention Is All You Need")
- Hugging Face `transformers` library
- Pretrained models: BERT (understanding), GPT-family (generation)

### Track B: Computer Vision
- Object detection (YOLO, Faster R-CNN)
- Image segmentation
- Vision Transformers (ViT)

**Projects:**
1. Fine-tune a BERT model for text classification (e.g., spam detection, news categorization)
2. Build a simple chatbot using a pretrained transformer
3. (CV track) Build an object detector for a custom dataset

---

## Phase 4 — Generative AI & LLMs (High Demand Right Now)

**Concepts:**
- How LLMs work (GPT architecture, tokens, context windows)
- Prompt engineering (zero-shot, few-shot, chain-of-thought)
- Embeddings & vector databases (for semantic search)
- **RAG (Retrieval-Augmented Generation)** — combining LLMs with your own data
- Fine-tuning vs. LoRA/QLoRA (parameter-efficient fine-tuning)
- AI Agents & tool use (function calling, multi-step reasoning)
- Multi-agent frameworks (LangChain, LangGraph, Semantic Kernel, or Microsoft's Agent Framework)

**Projects:**
1. **RAG-based Q&A bot** over your own documents (e.g., a bot that answers questions about your DSA notes) using a vector DB (FAISS/Chroma) + an LLM API
2. **AI coding assistant** — a small agent that can read a codebase and suggest improvements (ties directly into your C# background)
3. **Multi-agent workflow** — e.g., one agent researches a topic, another summarizes, another writes a report
4. Fine-tune a small open-source model (e.g., via LoRA) on a custom dataset

---

## Phase 5 — MLOps & Production

**Concepts:**
- Model deployment (REST APIs with FastAPI/Flask, containerization with Docker)
- Model versioning & experiment tracking (MLflow, Weights & Biases)
- CI/CD for ML pipelines
- Monitoring model drift in production
- Cloud AI platforms (Azure AI Foundry / AI Studio, given existing Azure tooling)

**Projects:**
1. Deploy one of your earlier models as a REST API and containerize it with Docker
2. Set up an experiment-tracking pipeline for a model you're iterating on
3. Deploy an LLM-powered app end-to-end on Azure (App Service/Container Apps) with monitoring

---

## Phase 6 — Advanced / Research-Level (Optional but valuable)

- Reinforcement Learning (Q-learning, policy gradients, RLHF — how ChatGPT-style models are aligned)
- Model architectures beyond Transformers (Mixture-of-Experts, state-space models like Mamba)
- Reading and implementing papers from scratch (arXiv, Papers with Code)
- Contributing to open-source AI projects

**Capstone project idea:** Build a full end-to-end AI product — e.g., an intelligent code-review agent that (1) uses RAG over your repo's history, (2) calls an LLM to review PRs, (3) is deployed as a service, (4) has monitoring/evaluation built in. This single project touches almost every phase above.

---

## Suggested Order of Attack
1. Python + math refresher (light touch, learn-by-doing)
2. Classical ML with scikit-learn → small projects
3. Deep learning fundamentals with PyTorch → MNIST/CNN project
4. Jump into LLMs/GenAI early (highest current relevance) — prompt engineering, RAG
5. Loop back to fill gaps (NLP theory, transformer internals) as needed
6. Add MLOps once you have models worth deploying

**Tip:** Don't try to master each phase linearly and completely before moving on — AI is best learned in a spiral: get a working project fast, then go deeper into the theory behind it.

---

## Progress Tracker

- [ ] Phase 0 — Prerequisites
- [ ] Phase 1 — Machine Learning Foundations
- [ ] Phase 2 — Deep Learning
- [ ] Phase 3 — Specializations
- [ ] Phase 4 — Generative AI & LLMs
- [ ] Phase 5 — MLOps & Production
- [ ] Phase 6 — Advanced / Research-Level
