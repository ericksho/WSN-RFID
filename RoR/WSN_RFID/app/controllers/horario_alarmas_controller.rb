class HorarioAlarmasController < ApplicationController
  before_action :set_horario_alarma, only: [:show, :edit, :update, :destroy]

  # GET /horario_alarmas
  # GET /horario_alarmas.json
  def index
    @horario_alarmas = HorarioAlarma.all
  end

  # GET /horario_alarmas/1
  # GET /horario_alarmas/1.json
  def show
  end

  # GET /horario_alarmas/new
  def new
    @horario_alarma = HorarioAlarma.new
  end

  # GET /horario_alarmas/1/edit
  def edit
  end

  # POST /horario_alarmas
  # POST /horario_alarmas.json
  def create
    @horario_alarma = HorarioAlarma.new(horario_alarma_params)

    respond_to do |format|
      if @horario_alarma.save
        format.html { redirect_to @horario_alarma, notice: 'Horario alarma was successfully created.' }
        format.json { render :show, status: :created, location: @horario_alarma }
      else
        format.html { render :new }
        format.json { render json: @horario_alarma.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /horario_alarmas/1
  # PATCH/PUT /horario_alarmas/1.json
  def update
    respond_to do |format|
      if @horario_alarma.update(horario_alarma_params)
        format.html { redirect_to @horario_alarma, notice: 'Horario alarma was successfully updated.' }
        format.json { render :show, status: :ok, location: @horario_alarma }
      else
        format.html { render :edit }
        format.json { render json: @horario_alarma.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /horario_alarmas/1
  # DELETE /horario_alarmas/1.json
  def destroy
    @horario_alarma.destroy
    respond_to do |format|
      format.html { redirect_to horario_alarmas_url, notice: 'Horario alarma was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_horario_alarma
      @horario_alarma = HorarioAlarma.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def horario_alarma_params
      params.require(:horario_alarma).permit(:hora_inicio, :fraccion_inicio, :hora_fin, :fraccion_fin, :motivo)
    end
end
