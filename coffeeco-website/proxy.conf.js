const PROXY_CONFIG = [
  {
    context: [
      "/bff",
      "/bff/*",
      "/signin-oidc",
      "/signin-oidc/*",
      "/signout-callback-oidc",
      "/signout-callback-oidc/*",
      "/uiapi",
      "/uiapi/*"
    ],
    target: process.env["services__buf__https__0"],
    secure: false,
  }
];

module.exports = PROXY_CONFIG;
