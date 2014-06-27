json.array!(@horario_alarmas) do |horario_alarma|
  json.extract! horario_alarma, :id, :hora_inicio, :hora_fin, :motivo
  json.url horario_alarma_url(horario_alarma, format: :json)
end
