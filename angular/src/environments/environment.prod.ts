import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Lotus',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44349',
    redirectUri: baseUrl,
    clientId: 'Lotus_App',
    responseType: 'code',
    scope: 'offline_access Lotus',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44349',
      rootNamespace: 'Lotus',
    },
  },
} as Environment;
