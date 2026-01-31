# Security Policy

## 🔒 Supported Versions

| Version | Supported |
| ------- | --------- |
| 1.x     | ✅ Yes    |
| < 1.0   | ❌ No     |

## 🚨 Reporting a Vulnerability

We take the security of AgriSim seriously. If you discover a security vulnerability, please follow these steps:

### Do NOT

- ❌ Open a public GitHub issue
- ❌ Disclose the vulnerability publicly before it's fixed

### Do

1. **Email us directly** at: 📧 **arshverma.dev@gmail.com**
2. Include the following information:
   - Description of the vulnerability
   - Steps to reproduce
   - Potential impact
   - Suggested fix (if any)

### What to Expect

| Timeframe   | Action                                     |
| ----------- | ------------------------------------------ |
| 24-48 hours | Initial response acknowledging your report |
| 7 days      | Assessment and severity determination      |
| 30 days     | Fix development and testing                |
| Post-fix    | Public disclosure (with credit if desired) |

## 🛡️ Security Best Practices for Contributors

When contributing to AgriSim:

1. **Never commit secrets** (API keys, passwords, tokens)
2. **Validate all inputs** in gameplay systems
3. **Use Unity's secure APIs** for file operations
4. **Report suspicious code** in pull requests

## 📋 Known Security Considerations

As a single-player game, AgriSim has limited attack surface. However:

- Save files are stored locally without encryption
- No network features are currently implemented
- Third-party assets follow Unity Asset Store licensing

---

Thank you for helping keep AgriSim secure! 🙏
