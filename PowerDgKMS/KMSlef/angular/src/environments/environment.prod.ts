export const environment = {
  production: true,
  application: {
    name: 'KMS',
    logoUrl: ''
  },
  oAuthConfig: {
    issuer: 'https://localhost:44392',
    clientId: 'KMS_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'KMS',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44365'
    }
  },
  localization: {
    defaultResourceName: 'KMS'
  }
};
