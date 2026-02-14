module.exports = [
  {
    context: [
      "/bff",
      "/bff/*",
      "/signin-oidc",
      "/signin-oidc/*",
      "/signout-callback-oidc",
      "/signout-callback-oidc/*",
      "/uiapi",
      "/uiapi/*",
    ],
    target:  process.env["services__bff__https__0"] ||
      process.env["services__bff__http__0"],
    secure: false,
  },
]
