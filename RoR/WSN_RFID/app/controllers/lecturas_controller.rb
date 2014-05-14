class LecturasController < ApplicationController
  before_action :set_lectura, only: [:show, :edit, :update, :destroy]

  # GET /lecturas
  # GET /lecturas.json
  def index
    @lecturas = Lectura.all
  end

  # GET /lecturas/1
  # GET /lecturas/1.json
  def show
  end

  # GET /lecturas/new
  def new
    @lectura = Lectura.new
  end

  # GET /lecturas/1/edit
  def edit
  end

  # POST /lecturas
  # POST /lecturas.json
  def create
    @lectura = Lectura.new(lectura_params)

    respond_to do |format|
      if @lectura.save
        format.html { redirect_to @lectura, notice: 'Lectura was successfully created.' }
        format.json { render :show, status: :created, location: @lectura }
      else
        format.html { render :new }
        format.json { render json: @lectura.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /lecturas/1
  # PATCH/PUT /lecturas/1.json
  def update
    respond_to do |format|
      if @lectura.update(lectura_params)
        format.html { redirect_to @lectura, notice: 'Lectura was successfully updated.' }
        format.json { render :show, status: :ok, location: @lectura }
      else
        format.html { render :edit }
        format.json { render json: @lectura.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /lecturas/1
  # DELETE /lecturas/1.json
  def destroy
    @lectura.destroy
    respond_to do |format|
      format.html { redirect_to lecturas_url, notice: 'Lectura was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_lectura
      @lectura = Lectura.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def lectura_params
      params.require(:lectura).permit(:fecha)
    end
end
